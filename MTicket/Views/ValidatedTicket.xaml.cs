using Domain.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MTicket.Views
{
    /// <summary>
    /// Lógica interna para ValidatedTicket.xaml
    /// </summary>
    public partial class ValidatedTicket : Window
    {
        public ValidatedTicket(Root entity, string storeName)
        {
            InitializeComponent();

            //Informações preenchidas pela API
            lblCreateAt.Content = lblCreateAt.Content + entity.response.createAt;
            lblItemId.Content = lblItemId.Content + entity.response.itemId;
            lblItem.Content = lblItem.Content + entity.response.item;

            //Definiçoes da tela (footer)
            lblDatetime.Content = DateTime.Now;
            lblMachineName.Content = $"Máquina: {Environment.MachineName}";
            lblStore.Content = storeName;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
