   M S B A M L   `   `   `  ����B  >MTicket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MTicketMTicket  5   	       MTicket.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MTicket     5   	     � Title$  MDC MTicket��5   	   $	��797��6   $
��1280��6*    � WindowStartupLocation$ CenterScreen=�67    � WindowState$ 	Maximized=�6\    � Icon$ /Views/mdc.ico��6t   ��5	      �� 5
   
    �� ImageSource$" /Views/Banner_AzulEscuro.png��6   .��5      �� $��0��6   $��0��6   $��	10,10,0,0q�6"   .+�5   
   ��  �� Left$ 38��6   
 �� Top$ 12��6"   �� 5   
   $��12222222222��6   $	 452��6&   $	 481��68    � 5   
   $�� ��6   $	��717��6   $
 -561��6(   $
 -365��6;   $
��1120��6M   #��� ��6Z   �� 5   
   -   5         ��Name$ 	txtQrcode��5      $��Digite o QrCode��6%    �� TextWrapping$
 Wrap=�6<   $	��274��6P   $��34��6\   $
 -138��6h   $ 12��6{   �� 5   
   -   5        	 ��Name$	 btnValid��5      $��VALIDAR��6#   $��32��65   $	��200��6A   $
 -101��6d   $ 76��6w   �� 5   
   $��40��6   $
 -561��6    $	 312��64   $
��1120��6E   #��� ��6R   �� 5   
   -   5        
 ��Name$
 lblDatetime��5      $��01/01/1999 10:00��6%   $	 422��6@   $	 319��6R   $	��113��6c   $
��Bold"�6o   
������� J� RenderTransformOrigin$ 1.015,0.688&�6�   �� 5   
   -   5        $
 lblStore��5      $��Empresa��6"   $
 -539��64   $	 319��6G   $	��219��6X   $
��Bold"�6d   
�������$ 1.015,0.688&�6�   �� 5   
   $	��256��6   $
 -149��6   $
 -256��60   $	��288��6B   $��/Views/ScanQrCode.png��6N   $ 0.5,0.5&�6m   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ -0.011Q�6&   T� 5      5       J� OpacityMask 5      �� 5      $ /Views/ScanQrCode.png��6   5!      �� 5"   
   -   5        $
 lblMachineName��5"      $��Machine Name��6(   $	 -77��6?   $	 319��6Q   $	��219��6b   $
��Bold"�6n   
�������$ 1.015,0.688&�6�   5$      5%      