   M S B A M L   `   `   `  ����=  9KR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KRKR  5   	       KR.Group_StagesAdmin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:KR     5   	     � Title$  Group_StagesAdmin��5   	   $	��500��6#   $	��800��60   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��400 �6   6+   �� 5      $	��100 �6   6+   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGrid��5         AutoGenerateColumns .     
IsReadOnly .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Група��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Abbreviature+6a     5      $ 1 місце��6%   $ * 6R    66   �� *	Team.ID+6^     5      $ 2 місце��6%   $ * 6S    66   �� *
Team1.ID+6_     5      $ 3 місце��6%   $ * 6S    66   �� *
Team2.ID+6_     5      $ 4 місце��6%   $ * 6S    66   �� *
Team3.ID+6_     5      $ 5 місце��6%   $ * 6S    66   �� *
Team4.ID+6_   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ auto  6)   	   CellTemplate	 5      �� 5      .R�5      �� 
 ��Name$
 BtnEdit��67   -   5        $��Змінити��5   %   6`   5      5      5      �� 5"      $��1��6   .+�5#      �� -   5        $��
Назад��5#      $��10q�6)    !  MaterialDesignPaperDarkButton#��[  6O   5$      5&      5'      