   M S B A M L   `   `   `  ����>  :LMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:LMS.WindowsLMS.Windows  5   	       LMS.Windows.BookWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:LMS.Windows     5   	     � Title$
  Book��5   	   $	��799��6   $	��997��6#    � WindowStartupLocation$ CenterScreen=�6/    � 
ResizeMode$ NoResize=�6T   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DgvBooks��5
      $��370,10,10,10q�6%      CanUserDeleteRows$ False��6;      
IsReadOnly$
 True��6U      AutoGenerateColumns$ False��6g      CanUserAddRows$ False��6�      CanUserResizeColumns$ False��6�   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.20* 6%      Header$
 Name��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Name+  5      $
 0.20* 6%   $ Genre��63    6B   �� *
Genre.Name+  5      $
 0.20* 6%   $ Author��63    6C   �� *Author+  5      $
 0.15* 6%   $ Price $��63    6D   �� *PricePerWeek+  5      $
 0.15* 6%   $ Quantity��63    6E   �� *
Quantity+  5      $
 0.10* 6%   $ Shelf��63    6B   �� *Shelf+5      � 5   
   $��	0,0,632,0q�6   .+�5      �� -   5         ��Name$ LblBName��5      $��Name of the Book*��6&   $��Center=�6B   $��0,54,0,0q�6_   $	��Top=�6q   $��29��6�   $	��146��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��15(�6�   �� 5      -   5         ��Name$ TxtBName��5      $��Center=�6(   $��0,98,0,0q�6E    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��214��6�   6�   �� 5      -   5        $ LblGenre��5      $��Genre*��6&   $��Center=�67   $��	0,146,0,0q�6T   $	��Top=�6g   $��29��6   $��63��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��15(�6�   �� 5      -   5        $ 	LblAuthor��5      $��Author*��6'   $��Center=�69   $	��Top=�6V   $��29��6n   $��84��6z   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��15(�6�   $��	0,364,0,0q�6�   �� 5      -   5        $ 	TxtAuthor��5      $
��Left=�6)   $��
78,417,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��214��6�   6�   �� 5      -   5        $ LblPrice��5      $��Price*��6&   $
��Left=�67   $	��Top=�6R   $��29��6j   $��62��6v   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��15(�6�   $��
76,470,0,0q�6�   �� 5      -   5        $ TxtPrice��5      $
��Left=�6(   $��186,470,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $��70��6�   $��29��6�   6�   �� 5      -	   5        $ 	LblDollar��5      $��$��6'   $
��Left=�63   $��169,470,0,0q�6N   $	��Top=�6c   $��29��6{   $��Center=�6�   $��Center=�6�   $��15(�6�   $
��Bold"�6�   �� 5      -
   5         ��Name$ BtnAddB��5      $	��Add��6&   $
��Left=�64   $��
49,694,0,0q�6O   $	��Top=�6c   6{   �� 5       -   5        $ BtnEditB��5       $
��Edit��6'   $��Center=�66   $��	0,694,0,0q�6S   $	��Top=�6f   ${�False��6~   6�   �� 5!      -   5        $ 
BtnDeleteB��5!      $��Delete��6)   $
��Left=�6:   $��244,694,0,0q�6U   $	��Top=�6j    J� RenderTransformOrigin$ 0.506,0.476&�6�   ${�False��6�   6�   �� 5"      -   5         ��Name$ LbGenre��5"      $��76,197,73,424q�6'   ���	#FFCCF4D96>   �� 5#      -   5        $ LblQuantity��5#      $��	Quantity*��6)   $
��Left=�6=   $	��Top=�6X   $��29��6p   $��81��6|   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��15(�6�   $��
76,552,0,0q�6�   �� 5$      -   5        $ TxtQuantity��5$      $
��Left=�6+   $��186,552,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $��70��6�   $��29��6�   6�   �� 5%      -   5        $ LblShelf��5%      $��Shelf*��6&   $
��Left=�67   $	��Top=�6R   $��29��6j   $��81��6v   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��15(�6�   $��
76,630,0,0q�6�   �� 5&      -   5        $ TxtShelf��5&      $
��Left=�6(   $��186,630,0,0q�6C   $
 Wrap=�6X   $	��Top=�6l   $��70��6�   $��29��6�   6�   5'      5)      5*      