   M S B A M L   `   `   `  ����=  9KR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KRKR  5   	       KR.TeamsAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:KR     5   	     � Title$  
TeamsAdmin��5   	   $	��500��6   $	��800��6)   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��400 �6   6+   �� 5      $	��100 �6   6+   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGrid��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6T     5      $ 
Назва��6%   $ * 6M    64   �� *Name+6Y     5      $ 
Група��6%   $ * 6Q    64   �� *
Group_ID+6]     5      $" Перемог в групі��6%   $ * 6`    6>   �� *Group_Win_Map+6l   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ auto  6)   	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 BtnEdit��67   -   5        $��Змінити��5   %   6`   5      5      5      �� 5!   
   $��1��6   $��Right=�6"   $��0, 0, 100 ,0q�6>   .+�5"      �� -   5        $��
Назад��5"      $��10q�6%   $��Center=�61    $   MaterialDesignOutlinedDarkButton#��[  6h   5#      �� 5'   
   $��1��6   $
��Left=�6"   $��100, 0, 0 ,0q�6>   .+�5(      �� -   5        $��Додати��5(      $��10q�6&   $��Center=�62    " MaterialDesignFlatDarkBgButton#��[ 6h   5)      5+      5,      