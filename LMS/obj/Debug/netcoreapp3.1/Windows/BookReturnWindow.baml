   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	   "    LMS.Windows.BookReturnWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$  Book Return��5   	   $	��600��6   $
��1210��6*    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ NoResize=�6\   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgvReturnBooks��5
         AutoGenerateColumns$ False��6+      
IsReadOnly$
 True��6G   $��10,278,10,10q�6Y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$
 Name��63   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6A   �� *Customer.Name+  5      $ 0.10* 6%   $ Surname��63   	 6D   �� *Customer.Surname+  5      $ 0.20* 6%   $ Phone��63   	 6B   �� *Customer.PhoneNumber+  5      $ 0.15* 6%   $ Created��63   	 6D   �� *	CreatedAt+
 �� StringFormat$
 {0:dd.MM.yyyy }��  5      $ 0.15* 6%   $ Deadline��63   	 6E   �� *
ReturnDate+$
 {0:dd.MM.yyyy }��  5      $ 0.10* 6%   $
 Fine��63   	 6A   �� *Fine+$
 	{0:0.00 }��  5      $ 0.10* 6%   $ Payment��63   	 6D   �� *
OrderPrice+$
 	{0:0.00 }��  5      $ 0.10* 6%   $ Total Price��63   	 6H   �� *
TotalPrice+$
 	{0:0.00 }��5      � 5   
   $��	0,0,0,311q�6   .+�5      �� -   5         ��Name$ LblSCustomer��5      $��Search For Customer��6*   $
��Left=�6H   $��	55,45,0,0q�6c   $	��Top=�6v   $��29��6�   $	��154��6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   �� 5      -   5         ��Name$ TxtSCustomer��5      $
��Left=�6,   $��
214,45,0,0q�6G    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��208��6�   $��29��6�   �� 5      -   5         ��Name$ 	BtnSearch��5      $��Search��6(   $
��Left=�69   $��
463,42,0,0q�6T   $	��Top=�6h   $	��120��6�   6�   �� 5      -   5        $ 	BtnReturn��5      $��Return The Book��6(   $
��Left=�6B   $��
55,154,0,0q�6]   $	��Top=�6q   $��50��6�   $	��156��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   6�   �� 5       -   5        $ 
LblMessage��5       $�� ��6(   $
��Left=�63   $��605,137,0,0q�6N   $	��Top=�6c   $��58��6{   $	��534��6�   ���	#DDFF00006�   5!      5#      5$      