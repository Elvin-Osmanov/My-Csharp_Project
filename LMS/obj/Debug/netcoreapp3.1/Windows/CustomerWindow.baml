   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	        LMS.Windows.CustomerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$  Customer��5   	   $	��501��6   $	��779��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X   .��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgvCustomers��5      $��254,10,10,10q�6)      CanUserDeleteRows$ False��6?      
IsReadOnly$
 True��6Y      AutoGenerateColumns$ False��6k      CanUserAddRows$ False��6�      CanUserResizeColumns$ False��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.15* 6%      Header$
 Name��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Name+  5      $
 0.15* 6%   $ Surname��63    6D   �� *	Surname+  5      $
 0.20* 6%   $ 
Birth Date��63    6G   �� *	BirthDate+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $
 0.20* 6%   $ Phone Number��63    6I   �� *PhoneNumber+  5      $
 0.30* 6%   $ 
Created At��63    6G   �� *	CreatedAt+5      � 5   
   $��	0,0,530,0q�6   .+�5      �� -   5         ��Name$ BtnAddC��5      $	��Add��6&   $
��Left=�64   $��
28,373,0,0q�6O   $	��Top=�6c   $��80��6{   $��26��6�   6�   �� 5      -   5        $ BtnEditC��5      $
��Edit��6'   $
��Left=�66   $��142,373,0,0q�6Q   $	��Top=�6f   $��78��6~   $��26��6�   ${�False��6�   6�   �� 5      -   5        $ 
BtnDeleteC��5      $��Delete��6)   $��Center=�6:   $��	0,420,0,0q�6W   $	��Top=�6j   $��80��6�   $��26��6�   ${�False��6�   6�   �� 5      -   5         ��Name$ LblCName��5      $��Name*��6&   $��Center=�66   $��0,22,0,0q�6S   $	��Top=�6e   $��80��6}   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ LblCSurname��5      $��Surname*��6)   $��Center=�6<   $��0,99,0,0q�6Y   $	��Top=�6k   $��80��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ 	LblCBirth��5      $��Date of Birth*��6'   $��Center=�6@   $��	0,264,0,0q�6]   $	��Top=�6p   $	��112��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DtpCBirthInner��5      $��Center=�61   $��	0,320,0,0q�6N   $	��Top=�6a   $	��112��6y   �� 5       -	   5         ��Name$ TxtCName��5       $��Center=�6(   $��0,55,0,0q�6E    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��192��6�   6�   �� 5!      -
   5        $ TxtCSurname��5!      $��Center=�6+   $��	0,132,0,0q�6H   $
 Wrap=�6[   $	��Top=�6o   $	��192��6�   6�   �� 5"      -   5        $ 	TxtCPhone��5"      $��Center=�6)   $��	0,218,0,0q�6F   $
 Wrap=�6Y   $	��Top=�6m   $	��192��6�   6�   �� 5#      -   5        $ 	LblCPhone��5#      $��Phone Number*��6'   $��Center=�6?   $��	0,185,0,0q�6\   $	��Top=�6o   $	��134��6�   $
��Bold"�6�   $��15(�6�   $��Center=�6�   $��Center=�6�   5$      5%      5&      