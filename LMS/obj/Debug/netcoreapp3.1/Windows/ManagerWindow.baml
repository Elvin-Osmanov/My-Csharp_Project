   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	       LMS.Windows.ManagerWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$  Manager��5   	   $	��753��6   $
��1252��6&    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgvManagers��5
      $��314,10,10,46q�6(      CanUserDeleteRows$ False��6>      
IsReadOnly$
 True��6X      AutoGenerateColumns$ False��6j      CanUserAddRows$ False��6�      CanUserResizeColumns$ False��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.20* 6%      Header$
 Name��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Name+  5      $
 0.20* 6%   $ Surname��63    6D   �� *	Surname+  5      $
 0.15* 6%   $
 Date��63    6A   �� *	BirthDate+ �� StringFormat$ {0:dd.MM.yyyy }��  5      $
 0.15* 6%   $ 
Speciality��63    6G   �� *
Speciality+  5      $
 0.20* 6%   $ Email��63    6B   �� *Email+  5      $
 0.10* 6%   $
 Pass��63    6A   �� *
Password+5      � 5   
   $��	0,0,938,0q�6   .+�5      �� $��New Manager��6   $��Center=�6*   $��0,10,0,0q�6G   $	��Top=�6Y   $	��289��6q   $��20(�6}   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   $��48��6�   ���	#DD05FF3E6�   �� 5      -   5         ��Name$ LblName��5      $��Name*��6%   $��Center=�65   $��0,63,0,0q�6R   $	��Top=�6d   $	��140��6|   $��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ 
LblSurname��5      $��Surname*��6(   $��Center=�6;   $��	0,139,0,0q�6X   $	��Top=�6k   $	��140��6�   $��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5      -   5        $ LblDate��5      $��Date of  Birth*��6%   $��Center=�6?   $��	0,217,0,0q�6\   $	��Top=�6o   $	��140��6�   $��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ DtpDate��5      $��Center=�6*   $��	0,262,0,0q�6G   $	��Top=�6Z   $	��140��6r   �� 5      -   5         ��Name$ TxtMsurname��5      $��Center=�6+   $��	0,186,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��180��6�   $��26��6�   6�   �� 5      -   5        $ TxtMname��5      $��Center=�6(   $��	0,108,0,0q�6E   $
 Wrap=�6X   $	��Top=�6l   $	��180��6�   $��26��6�   6�   �� 5      -   5        $ LblSpeciality��5      $��Speciality*��6+   $��Center=�6A   $��	0,314,0,0q�6^   $	��Top=�6q   $	��140��6�   $��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5      -	   5        $ TxtSpeciality��5      $��Center=�6-   $��	0,366,0,0q�6J   $
 Wrap=�6]   $	��Top=�6q   $	��180��6�   $��26��6�   6�   �� 5      -
   5         ��Name$ BtnAddM��5      $	��Add��6&   $
��Left=�64   $��
96,568,0,0q�6O   $	��Top=�6c   $	��114��6{   $��33��6�   ���	#DDFFFFFF6�   �� 5       -   5        $ BtnEditM��5       $
��Edit��6'   $��Center=�66   $��	0,622,0,0q�6S   $	��Top=�6f   $	��114��6~   $��33��6�   ���	#DDFFFFFF${�False��6�   6�   �� 5!      -   5        $ 
BtnDeleteM��5!      $��Delete��6)   $��Center=�6:   $��	0,676,0,0q�6W   $	��Top=�6j   $	��112��6�   $��33��6�   ���	#DDFFFFFF${�False��6�   6�   �� 5"      -   5        $ LblEmail��5"      $��Email*��6&   $��Center=�67   $��	0,397,0,0q�6T   $	��Top=�6g   $	��140��6   $��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5#      -   5        $ LblPass��5#      $��	Password*��6%   $
��Left=�69   $��112,481,0,0q�6T   $	��Top=�6i   $��82��6�   $��15(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   �� 5$      -   5        $ TxtEmail��5$      $��Center=�6(   $��	0,430,0,0q�6E   $
 Wrap=�6X   $	��Top=�6l   $	��180��6�   $��26��6�   6�   �� 5%      -   5        $ TxtPassword��5%      $
��Left=�6+   $��
63,509,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��180��6�   $��26��6�   6�   5&      5'      5(      