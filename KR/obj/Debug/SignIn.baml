   M S B A M L   `   `   `  ����=  9KR, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:KRKR  5   	       	KR.SignIn   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:KR  5   	     � Title$  SignIn��5	   	   $	��550��6   $	��600��6%   .��5
      � 
�������.+�5   
   �� 
�������$	��350��6$   $	��450��63   $�� 0q�6B   $��Center=�6N    �� Padding$ 10q�6i    �� CornerRadius$ 25��6v    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$
 Gray��63      ShadowDepth$ 1Q�6@   ._�5      �� .+�5      �� $��Вхід��6    �� TextAlignment$ Center=�6(   $��30(�6?   $��Verdana)�6M   $��
20 20 20 0q�6b   �� 5      -   5         ��Name$ TextBoxLogin��5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введіть логін��61   $�� 20 10 20 20q�6`    %  !MaterialDesignFloatingHintTextBox#��[  6v   G� 5      -   5        
 G�Name$
 PasswordBox��5      $!	 Введіть пароль��65   $��20 10 20 20q�6e    ) %MaterialDesignFloatingHintPasswordBox#��[ 6z   �� 5      -   5        $��Ввійти��5      $��
20 20 20 0q�6*    " MaterialDesignFlatDarkBgButton#��[ 6Z   �� 5      -   5        $��
Назад��5      $��20q�6)     MaterialDesignPaperButton#��[ 6O   �� 5      -   5        $*��$Продовжити як гість��5      $��
20 0 20 20q�67   #��[ 6f   5      5      5      5      