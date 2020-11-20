using Domain.Model.Entities;
using Microsoft.Extensions.Options;
using MTicket.Views;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ITicketService _ticketService;
        private readonly IStoreService _storeService;
        private readonly IOptions<AppSettings> _settings;

        public static string storeName = "";

        public MainWindow(ITicketService ticketService, IStoreService storeService, IOptions<AppSettings> settings)
        {
            InitializeComponent();

            //Injeção de dependecias
            _ticketService = ticketService;
            _storeService = storeService;
            _settings = settings;

            //Definiçoes da tela (footer)
            lblDatetime.Content = DateTime.Now;
            lblMachineName.Content = $"Máquina: {Environment.MachineName}";
            storeName = _storeService.GetStoreName().Result;
            lblStore.Content = storeName;
        }

        private async void btnValid_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var entity = new Ticket
                {
                    QrCode = txtQrcode.Text
                };

                var result = await _ticketService.getStatusTicket(entity);

                if (result.response != null)
                {
                    switch (result.meta.status_code)
                    {
                        case 0:
                            var formValidatedTicket = new ValidatedTicket(result, storeName);
                            formValidatedTicket.ShowDialog();
                            break;
                        case -1:
                            var formUsedTicket = new UsedTicket(result, storeName);
                            formUsedTicket.ShowDialog();
                            break;
                        case 2:
                            var formInvalidTicket = new InvalidTicket(storeName);
                            formInvalidTicket.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Não foi possivel validar o ticket, tente novamente por favor.");
                            break;
                    }
                }
                else
                {
                    var formInvalidTicket = new InvalidTicket(storeName);
                    formInvalidTicket.ShowDialog();
                }

                txtQrcode.Text = "Digite o QrCode";
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
