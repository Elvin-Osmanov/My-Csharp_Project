   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	   #    LMS.Windows.SalesReportWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$  SalesReportWindow��5   	   $	��450��6#   $	��800��60   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DgvExport��5
      $��10,182,10,10q�6&      CanUserAddRows$ False��6=      AutoGenerateColumns$ False��6T      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.15* 6%      Header$
 Name��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Customer.Name+  5      $ 0.15* 6%   $ Surname��63    6D   �� *Customer.Surname+  5      $ 0.20* 6%   $ Phone��63    6B   �� *Customer.PhoneNumber+  5      $ 0.15* 6%   $ Created��63    6D   �� *	CreatedAt+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $ 0.15* 6%   $ Deadline��63    6E   �� *
ReturnDate+$ {0:dd.MM.yyyy }��  5      $ 0.10* 6%   $
 Fine��63    6A   �� *Fine+$ 	{0:0.00 }��  5      $ 0.10* 6%   $ Payment��63    6D   �� *
OrderPrice+$ 	{0:0.00 }��5      �� 5   
   -   5        	 ��Name$	 LblStart��5      $��
Start Date��6"   $
��Left=�67   $��	43,33,0,0q�6R   $	��Top=�6e   $��29��6}   $��93��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   �� 5   
   -   5        $	 LblEnd��5      $��End Date��6    $
��Left=�63   $��
225,33,0,0q�6N   $	��Top=�6b   $��29��6z   $��93��6�   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   �� 5   
   -   5        
 ��Name$
 BtnDataShow��5      $��Search��6&   $
��Left=�67   $��
542,48,0,0q�6R   $	��Top=�6f   $	��144��6~   $��42��6�   6�   �� 5   
   -   5        $
 	BtnExport��5      $��Export��6$   $
��Left=�65   $��542,117,0,0q�6P   $	��Top=�6e   $	��144��6}   $��42��6�   6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ DtpStartDate��5      $
��Left=�6+   $��
43,117,0,0q�6F   $	��Top=�6Z   $��93��6r     5   
   -   5        $ 
DtpEndDate��5      $
��Left=�6)   $��225,117,0,0q�6D   $	��Top=�6Y   $��93��6q   5      5      