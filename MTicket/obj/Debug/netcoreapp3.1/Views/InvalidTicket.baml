   M S B A M L   `   `   `  ����B  >MTicket, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MTicketMTicket  5   	   !    MTicket.Views.InvalidTicket   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MTicket     5   	     � Title$$  MDC MTicket - Ticket Utilizado��5   	   $	��797��60   $
��1280��6=    � WindowStartupLocation$ CenterScreen=�6J    � WindowState$ 	Maximized=�6o    � Icon$ /Views/mdc.ico��6�    � ShowInTaskbar$ False��6�   ��5	      �� 5
   
    �� ImageSource$" /Views/Banner_AzulEscuro.png��6   .��5      �� $��0��6   $��0��6   $��	10,10,0,0q�6"   .+�5   
   ��  �� Left$ 38��6   
 �� Top$ 12��6"   �� 5   
   $��12222222222��6   $	 452��6&   $	 481��68    � 5   
   -   5          �Name$ lblCreateAt_��5      $�� ��6&   $	��717��61   $
 -561��6>   $
 -365��6Q   $
��1120��6c   #��� ��6p   �� 5   
   $��40��6   $
 -561��6    $	 312��64   $
��1120��6E   #��� ��6R   �� 5   
   -   5        	 ��Name$	 lblDatetime��5      $��01/01/1999 10:00��6%   $	 422��6@   $	 319��6R   $	��113��6c   $
��Bold"�6o   
�������
 J� RenderTransformOrigin$
 1.015,0.688&�6�   �� 5   
   -   5        $	 lblStore��5      $��Empresa��6"   $
 -539��64   $	 319��6G   $	��219��6X   $
��Bold"�6d   
�������$
 1.015,0.688&�6�   �� 5   
   -   5        $	 lblMachineName��5      $��Machine Name��6(   $	 -77��6?   $	 319��6Q   $	��219��6b   $
��Bold"�6n   
�������$
 1.015,0.688&�6�   �� 5   
   $	��677��6   $
 -561��6!   
���   �$
 -365��6C   $
��1120��6U   
���  ��6b   �� 5   
   -   5        $	 	lblResult��5      $2��,Ticket não foi localizado ou é inválido.
��6#   $��122,238,0,0q�6[   $	��370��6p   $��60��6|   $��18(�6�   $
��Bold"�6�   $
 -276��6�   $
 -327��6�   �� 5   
   $	��100��6   $��182,128,0,0q�6   $	��100��62   $��/Views/x-mark.png��6>   $
 0.5,0.5&�6Y   $
 -222��6y   $
 -334��6�   z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 180.027Q�6&   T� 5      5      5      �� 5    
   -   5         ��Name$ btnClose��5       $��OK��6#   $	 -42��60   $ 39��6B   $��64��6R   $	��108��6^   6j   5!      5"      