   M S B A M L   `   `   `  ����D  @Events2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Events2._0.PagesEvents2._0.Pages  5      $    Events2._0.Pages.Authorization   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Events2._0.Pages     5      -   5          N�Name$  AuthorizationPage��5	   0    N� Title$ Authorization��6    N� 
Background
 �����.��5      � -   5         �Name$ txtPassword��5       � ColumnDefinitions 5   
   �� 5      $	��260 �6   �� 5      �� 5      $	��260 �6   .+�5   
   �� $��1��6   $��1��6"   $��Center=�62   $��Center=�6O   .+�5      �� $��Логин:��6   �� 5      -   5         ��Name$ txtLogin��5      �� 5      $��Пароль:��6   G� 5      -   5         G�Name$ 
paswordBox��5      $��5q�6.   $��21.51��69   �� 5      -   5         ��Name$ textBlockCaptcha��5      $y�Hidden=�62   �� 5      -   5        $ txtBlockCaptcha��5      $
��Left=�62   $��	TextBlock��6O   $	��Top=�6`   $y�Hidden=�6x   �� 5      -   5        $ 
txtCaptcha��5      $y�Hidden=�6*   �� 5       �� Orientation$ 
Horizontal=�6   $��80��62   $��Center=�6>   .+�5      �� -   5        	 ��Name$	 btnEnterGuest��5      $��5 15 5 5q�60   $"��Войти как гость��6B   6\   �� 5      -	   5        $	 btnEnter��5      $��5, 15, 5, 5q�6+   $��
Войти��6@   6P   5      5      �� 5   
   -
   5        $ txtBlockTimer��5      $��2��6+   $
��Left=�6;   $��
10,128,0,0q�6V   $
��Wrap=�6j   $��	TextBlock��6~   $	��Top=�6�   5#      5$      