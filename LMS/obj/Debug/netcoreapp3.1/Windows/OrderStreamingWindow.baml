   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	   &     LMS.Windows.OrderStreamingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$  OrderStreamingWindow��5   	   $	��585��6&   $
��1298��63   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgvTomorrow��5
      $��10,240,865,10q�6(      AutoGenerateColumns$ False��6?      CanUserAddRows$ False��6\      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.25* 6%      Header$
 Name��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Order.Customer.Name+  5      $ 0.25* 6%   $ Surname��63    6D   �� *Order.Customer.Surname+  5      $ 0.25* 6%   $ Phone��63    6B   �� *Order.Customer.PhoneNumber+  5      $ 0.25* 6%   $
 Book��63    6A   �� *	Book.Name+5        5   
   -   5        $ DgvToday��5      $��455,240,437,10q�6%   $ False��6=   $ False��6Y    5        5      $ 0.25* 6%   $
 Name��63    6A   �� *Order.Customer.Name+  5      $ 0.25* 6%   $ Surname��63    6D   �� *Order.Customer.Surname+  5      $ 0.25* 6%   $ Phone��63    6B   �� *Order.Customer.PhoneNumber+  5      $ 0.25* 6%   $
 Book��63    6A   �� *	Book.Name+5        5   
   -   5        $ DgvYesterday��5      $��883,240,9,10q�6)   $ False��6?   $ False��6[    5        5      $ 0.25* 6%   $
 Name��63    6A   �� *Order.Customer.Name+  5      $ 0.25* 6%   $ Surname��63    6D   �� *Order.Customer.Surname+  5      $ 0.25* 6%   $ Phone��63    6B   �� *Order.Customer.PhoneNumber+  5      $ 0.25* 6%   $
 Book��63    6A   �� *	Book.Name+5!      �� 5"   
   -   5         ��Name$ LblTomorrow��5"      $"��Books On Return for Tomorrow��6%   $
��Left=�6L   $��	76,69,0,0q�6g   $	��Top=�6z   $��64��6�   $	��292��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   ���	#DD00FF966  �� 5#   
   -   5        $ LblToday��5#      $��Books On Return for Today��6"   $
��Left=�6F   $��
512,69,0,0q�6a   $	��Top=�6u   $��64��6�   $	��292��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   ���	#DD00FF966  �� 5$   
   -   5        $ LblYesterday��5$      $��Expired Deadlines��6&   $
��Left=�6B   $��
940,69,0,0q�6]   $	��Top=�6q   $��64��6�   $	��292��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   ���	#DD00FF966  5%      5&      