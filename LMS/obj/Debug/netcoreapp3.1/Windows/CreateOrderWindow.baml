   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	   #    LMS.Windows.CreateOrderWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$  CreateOrderWindow��5   	   $	��494��6#   $
��1473��60    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6b   .��5	      � .+�5
   
   � $��
0,0,1142,0q�6   .+�5      �� -   5         ��Name$ 
LblCSearch��5      $��Customer Search��6(   $��Center=�6B   $��0,23,0,0q�6_   $	��Top=�6q   $	��126��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5      -   5         ��Name$ 
TxtCSearch��5      $��Center=�6*   $��0,71,0,0q�6G    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��206��6�   �� 5      -   5        $ LblCList��5      $��List of Customers��6&   $��Center=�6B   $��	0,211,0,0q�6_   $	��Top=�6r   $	��206��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5      -   5         ��Name$ 
BtnCSearch��5      $��Search��6)   $��Center=�6:   $��	0,124,0,0q�6W   $	��Top=�6j   $	��126��6�   6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ DgvSCustomers��5      $��10,300,10,10q�6/      CanUserSortColumns$ False��6E   	   CanUserAddRows$	 False��6`   
   AutoGenerateColumns$
 False��6w      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.25* 6)      Header$
 Name��67   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *Name+  5      $ 0.25* 6)   $ Surname��67    6H   �� *	Surname+  5      $ 0.50* 6)   $ Phone Number��67    6M   �� *PhoneNumber+5      �� 5      -   5        $ LblSelectedC��5      $��Please Select Customer��6*   $y�Hidden=�6K   $��Center=�6_   $��	0,244,0,0q�6|   $	��Top=�6�   $	��259��6�   
����������	#DDFF0000$
��Bold"�6�   $��Center=�6�   $��Center=�6  $��29��65  $��15(�6A  5      � 5   
   $��680,0,583,0q�6   .+�5      �� -   5        $ 
BtnCartAdd��5      $��Create Order��6)   $��Center=�6@   $	��Top=�6]   $	��148��6u   $��62��6�   $
��Bold"�6�   $��	0,369,0,0q�6�   �� 5      -   5        $ LblDeadLine��5      $��Deadline��6)   $��Center=�6<   $��	0,155,0,0q�6Y   $	��Top=�6l   $��24��6�   $��98��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   (  "System.Windows.Controls.DatePicker  5      -	   5          Name$ DtpDeadline��5      $��Center=�6.   $��	0,201,0,0q�6K   $	��Top=�6^   $��38��6v   $	��148��6�   $��Center=�6�   $��Center=�6�   �� 5      -
   5        $ LblCreatedOrderDt��5      $��Order Created Date��6/   $��Center=�6L   $��0,23,0,0q�6i   $	��Top=�6{   $��24��6�   $	��190��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�     5      -   5        $ DtpOrderCreatedDate��5      $��Center=�66   $��0,81,0,0q�6S   $	��Top=�6e   $��38��6}   $	��148��6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ LblReturnDate��5      $��Please select deadline ��6+   $y�Hidden=�6M   $��Center=�6a   $��	0,291,0,0q�6~   $	��Top=�6�   $	��190��6�   $��44��6�   ���	#DDFF0000$��Center=�6�   $��Center=�6�   $��15(�6  $
��Bold"�6,  5         5!   
   -   5        $ 	DgvOrders��5!      $��895,10,10,37q�6&   $
 False��6<   $	 False��6X      CanUserDeleteRows$ False��6o    5"        5#      $ 0.20* 6%   $ Customer��63    6E   �� *Order.Customer.Name+  5$      $ 0.20* 6%   $
 Book��63    6A   �� *	Book.Name+  5%      $ 0.20* 6%   $ Price Per Week��63    6K   �� *Book.PricePerWeek+ �� StringFormat$ 	{0:0.00 }��  5&      $ 0.20* 6%   $ Total Price��63    6H   �� *Order.OrderPrice+$ 	{0:0.00 }��  5'      $ 0.20* 6%   $ 
Order Date��63    6G   �� *Order.CreatedAt+  5(      $ 0.20* 6%   $ Deadline��63    6E   �� *Order.ReturnDate+5,      � 5-   
   $��336,0,798,0q�6   .+�5.      �� -   5        $ 
LblBSearch��5.      $��Book Search��6(   $��Center=�6>   $��0,23,0,0q�6[   $	��Top=�6m   $	��126��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5/      -   5        $ 
TxtBSearch��5/      $��Center=�6*   $��0,69,0,0q�6G   $
 Wrap=�6Y   $	��Top=�6m   $	��216��6�   $��29��6�   �� 50      -   5        $ 
BtnBSearch��50      $��Search��6)   $��Center=�6:   $��	0,123,0,0q�6W   $	��Top=�6j   $	��126��6�   6�   �� 51      -   5        $ LblBList��51      $��List of Books��6&   $��Center=�6>   $��	0,211,0,0q�6[   $	��Top=�6n   $	��206��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�     52      -   5        $ 	DgvSBooks��52         SelectionMode$ Extended=�6*   $��10,305,10,10q�6C   $ False��6Y   $	 False��6t   $
 False��6�    53        54      $ 0.40* 6)   $
 Name��67    6E   �� *Name+  55      $ 0.40* 6)   $ Author��67    6G   �� *Author+  56      $ 0.20* 6)   $ Price��67    6F   �� *Price+58      �� 59      -   5        $ LblSelectedB��59      $��Please Select Book��6*   $y�Hidden=�6G   $��Center=�6[   $��	0,244,0,0q�6x   $	��Top=�6�   $	��259��6�   
����������	#DDFF0000$
��Bold"�6�   $��Center=�6�   $��Center=�6  $��29��61  $��15(�6=  5:      5<      5=      