   M S B A M L   `   `   `  ����K  GStudentTest.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentTest.ViewStudentTest.View  5   	   ?$clr-namespace:StudentTest.View.ViewsStudentTest.View.Views  5   	   !    StudentTest.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentTest.View     5   	   6
viewmodelsclr-namesoace:StudentTest.Views     5   	   9controls$clr-namespace:StudentTest.View.Views     5   	   -   5          �Name$  window��5   	    � Title$ 
MainWindow��5
   	   $	��750��6   $
��1000��6)   
������  � AllowsTransparency$
 True��6O    � WindowStyle$
 None=�6i    � 
ResizeMode$ NoResize=�6|    � WindowStartupLocation$ CenterOwner=�6�   .��5      ��  �� CornerRadius$ 20��6   ._�5   
   � -   5         �Name$ Window��5      
���   �.+�5      � ��5      �� 5       �� 
TargetType" �6   	 �� Triggers	 5      �� 5      
 �� Binding
 6*   �� *
IsLoggedIn+ �� Value	 False6I   .a�5   "   ��  �� Property � y� �� Value$ Hidden=�6?   5      5      .+�5      %   StudentTest.View.Views.UserView  5      �� 5      $��1��6   $��Disabled=�6(   $��Disabled=�6O   .��5      �� ��6!   �� *CurrentViewModel+5      5!      5#      5$      