   M S B A M L   `   `   `  ����D  @Events2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Events2._0.PagesEvents2._0.Pages  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 64       Events2._0.Pages.Client   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Events2._0.Pages     5      6sys&clr-namespace:System;assembly=mscorlib     64     N� Title$  Client��5	       � 	Resources 5
         defaultImage��%6   &	        ��5   
   /Resources/shrek.png��6@   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��220* �6   6.   �� 5      $
��200* �6   6.   �� 5      $
��200* �6   6.   �� 5      $	��80* �6   6-    � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��56 �6   6*   �� 5      6   �� 5      $��60 �6   6*   .+�5   
   (  "System.Windows.Controls.DatePicker  -   5        $��
datePicker��5      $��1��6'   $��0��64   $��Center=�6D   $��5, 0,5,0q�6_   6q   �� 5   
   -   5        $��
cmbSorting��5      $��1��6%   $��1��62    �� SelectedIndex$ 0��6B   $��Center=�6T   $��5,0,5,0q�6o   6�   �� 5   
   -   5        $��	cmbFilter��5      $��1��6$   $��2��61   $ 0��6A   $��Center=�6S   $��5,0,5,0q�6n   ��6   �� *SortingList+6�   �� 5    
   -   5        $��
LViewEvent��5       $��0��6%   $��4��65   $��2��6I   $��5,5,5,5q�6V   ��5!      �� 5"       �� 
TargetType" ��6   .�5#      ��  �� Property � �� �� Value$ Stretch=�6C   6U   5$      ��5&      �� 5'      .R�5(      �� 
���   �$��1q�61   ��6E   �� *
Background+._�5)      �  5*      �� 5+   "   $	��200 �63   6A   �� 5,   "   $��* �63   6?   �� 5-   "   $	��100 �63   6A   .+�50      �� $	��180��6$   $	��100��60   $��5q�6=   ��6H   �� *	ImgPath+ �� FallbackValue# [  6�   �� 52      $��1��6)   $��5q�69   .+�53   "   �� 	 �� Orientation$	 
Horizontal=�6-   .+�54   &   �� 
 ��Name$
 tblEventsName��60   $
��Bold"�6`   ��6G   �� *	Events1+6`   �� 55   &   $
 	tblDateEv��60   ��6C   �� *DATE+�� 56   &   $
 tblDayEv��60   ��6B   �� *DAYS+�� 57   &   $
 	tblCityEv��60   ��6C   �� *City1.City1+58   #   59      5;      5<      5=      5?      5A      5B      