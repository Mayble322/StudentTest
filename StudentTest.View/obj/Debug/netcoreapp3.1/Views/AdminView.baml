   M S B A M L   `   `   `  ����K  GStudentTest.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:StudentTest.View.ViewsStudentTest.View.Views  5      &     StudentTest.View.Views.AdminView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:StudentTest.View.Views     5      .��5	      � .+�5
   
   � -   5          �Name$  Category��5
      $��74,38,629,215q�5      .+�5      ��  J� IsHitTestVisible$ False��5      $��NSimSun)�5      $	��Top=�5      $
��Left=�5      $��	0,160,0,0q�5      
���  ��$��16(�5      $��25��5      $	��293��5       � DataContext 5      �� *ErrorMessageViewModel2+��5      �� *	Message+y�5      �� *
HasMessage+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � y� �� Value$ 	Collapsed=�67   5      5       �� 5!      $ False��5"      $��NSimSun)�5#      $	��Top=�5$      $
��Left=�5%      $��556,512,0,0q�5&      
���  ��$��16(�5(      $��25��5)      $	��293��5*       5+      �� *ErrorMessageViewModel+��5,      �� *	Message+y�5-      �� *
HasMessage+��50      �� 51      " ��6   .�52      ��  � y�$ 	Collapsed=�67   53      55      �� 56      $
��Left=�57      $��Category��58      $��32��59      $��	97,10,0,0q�5:      $
��Wrap=�5;      $	��Top=�5<      $	��106��5=      
�������$��20(�5?      $��NSimSun)�5@       �� TextAlignment$ Center=�5A       J� RenderTransformOrigin$ 0.689,0.469&�6(   �� 5B      -   5         ��Name$ CategoryBox��5C      $��Center=�5D      $��34��5E      $��0,79,0,0q�5F      	 �� TextWrapping$
	 Wrap=�5G      $	��Top=�5H      $	��293��5I      
���   �
 �� SelectionBrush
 �	#FF232629$��NSimSun)�5L      $��16(�5M      $
��Left=�5N      $��Center=�5O       �� 	MaxLength$ 12��63   ��5P      �� *CategoryName+ �� UpdateSourceTrigger$ PropertyChanged=��� 5W      $��Creation��5X      $
��Left=�5Y      $��24��5Z      $��
92,131,0,0q�5[      $	��Top=�5\      $	��116��5]      $ 
0.495,1.19&�5^      
�������$��NSimSun)�5b      $��16(�5c      ��5_      Z� ��5`      Z� ��5d      �� *CategoryCreationCommand+�� 5g      $ False��5h      $��NSimSun)�5i      $	��Top=�5j      $
��Left=�5k      $��
-6,160,0,0q�5l      
���  ��$��16(�5n      $��25��5o      $	��293��5p       5q      �� *ErrorMessageViewModel+��5r      �� *	Message+��5v      �� 5w      " ��6   .�5x      ��  � y�$ 	Collapsed=�67   5y      5{      �� 5}      -   5        $ CountQuestionsBox��5~      $��Center=�5      $��34��5�      $
	 Wrap=�5�      $��Center=�5�      $	��293��5�      
���   �
 �	#FF232629$��NSimSun)�5�      $��16(�5�      $
��Left=�5�      $��Center=�5�      $ 12��63   ��5�      �� *CountQuestions+$ PropertyChanged=��� 5�      $��CreationCount��5�      $
��Left=�5�      $��24��5�      $��
78,287,0,0q�5�      $	��Top=�5�      $	��144��5�      $ 
0.495,1.19&�5�      
�������$��NSimSun)�5�      $��16(�5�      ��5�      Z� ��5�      Z� ��5�      �� *CountQuestionsCreationCommand+�� 5�      $��Get CategoryList��5�      $
��Left=�5�      $��24��5�      $��
50,329,0,0q�5�      $	��Top=�5�      $	��200��5�      $ 
0.495,1.19&�5�      
�������$��NSimSun)�5�      $��16(�5�      ��5�      Z� ��5�      Z� ��5�      �� *CategoryGetCommand+�� 5�      $
��Left=�6   $��50,358,0,23q�64   .+�5�      A� 
������� A� Columns$ 1��61   .+�5�      �� $	��200��5�      $��Center=�5�       �� SelectionMode$ Extended=�5�      $��1��5�      $��Stretch=�5�      
������ $��0q�5�      $��Disabled=�5�      ��5�      �� *GetCollection+ �� SelectedItem 5�      �� *
Category+5�      5�      5�      5�      � 5�   
   -   5        $
  Quiz��5�      $��629,38,74,103q�5�      .+�5�      �� $
��Left=�5�      $
��Quiz��5�      $��31.922��5�      $��83.529,10,0,0q�5�      $
��Wrap=�5�      $	��Top=�5�      $��106.064��5�      
�������$��20(�5�      $��NSimSun)�5�      $ Center=�5�      �� 5�      -   5        $ QuestionBox��5�      $
��Left=�5�      $��34��5�      $��2,99,0,0q�5�      $
	 Wrap=�5�      $	��Top=�5�      $	��293��5�      
���   �
 �	#FF232629$��NSimSun)�5�      $��16(�5�      $
��Left=�5�      $��Center=�5�      $ 12��63   ��5�      �� *
Question+$ PropertyChanged=��� 5�      -   5        $ 
AnswerABox��5�      $��Center=�5�      $��34��5�      $��	0,162,0,0q�5�      $
	 Wrap=�5�      $	��Top=�5�      $	��293��5�      
���   �
 �	#FF232629$��NSimSun)�5�      $��16(�5�      $
��Left=�5�      $��Center=�5�      $ 12��63   ��5�      �� *	AnswerA+$ PropertyChanged=��� 5�      -   5        $ 
AnswerBBox��5�      $��Center=�5�      $��34��5�      $��	0,225,0,0q�5�      $
	 Wrap=�5�      $	��Top=�5�      $	��293��5�      
���   �
 �	#FF232629$��NSimSun)�5      $��16(�5     $
��Left=�5     $��Center=�5     $ 12��63   ��5     �� *	AnswerB+$ PropertyChanged=��� 5     -   5        $ 
AnswerCBox��5	     $��Center=�5
     $��34��5     $��	0,288,0,0q�5     $
	 Wrap=�5     $	��Top=�5     $	��293��5     
���   �
 �	#FF232629$��NSimSun)�5     $��16(�5     $
��Left=�5     $��Center=�5     $ 12��63   ��5     �� *	AnswerC+$ PropertyChanged=��� 5     -	   5        $ 
AnswerDBox��5     $��Center=�5     $��34��5     $��	0,351,0,0q�5     $
	 Wrap=�5      $	��Top=�5!     $	��293��5"     
���   �
 �	#FF232629$��NSimSun)�5%     $��16(�5&     $
��Left=�5'     $��Center=�5(     $ 12��63   ��5)     �� *	AnswerD+$ PropertyChanged=��� 5-     -
   5        $ CorrectAnsBox��5.     $��Center=�5/     $��34��50     $��	0,414,0,0q�51     $
	 Wrap=�52     $	��Top=�53     $	��293��54     
���   �
 �	#FF232629$��NSimSun)�57     $��16(�58     $
��Left=�59     $��Center=�5:     $ 12��63   ��5;     �� *
CorrectAns+$ PropertyChanged=��� 5>     $ False��5?     $��NSimSun)�5@     $	��Top=�5A     $��Center=�5B     $��	0,534,0,0q�5C     
���  ��$��16(�5E     $��25��5F     $	��293��5G      5H     �� *ErrorMessageViewModel2+��5I     �� *	Message+��5L     �� 5M     " ��6   .�5N     ��  � y�$ 	Collapsed=�67   5O     5Q     �� 5T     $��Creation��5U     $
��Left=�5V     $��24��5W     $��
84,480,0,0q�5X     $	��Top=�5Y     $	��117��5Z     $ 
0.495,1.19&�5[     
�������$��NSimSun)�5_     $��16(�5`     ��5\     Z� ��5]     Z� ��5a     �� *QuizCreationCommand+5b     �� 5c  
   $
��Left=�6   $��Category Name :��5d     $��	74,83,0,0q�5e     
�������$��20(�5g     $��NSimSun)�5h     $ Center=�5i     $
��Wrap=�5j     $	��Top=�5k     $��35��5l     $	��168��5m     �� 5n  
   $
��Left=�6   $��Count of question :��5o     $��
74,233,0,0q�5p     
�������$��20(�5r     $��NSimSun)�5s     $ Center=�5t     $
��Wrap=�5u     $	��Top=�5v     $��35��5w     $	��199��5x     �� 5y  
   $
��Left=�6   $��
Question :��5z     $��
629,99,0,0q�5{     
�������$��20(�5}     $��NSimSun)�5~     $ Center=�5     $
��Wrap=�5�     $	��Top=�5�     $��35��5�     $	��113��5�     �� 5�  
   $
��Left=�6   $��
Answer A :��5�     $��629,169,0,0q�5�     
�������$��20(�5�     $��NSimSun)�5�     $ Center=�5�     $
��Wrap=�5�     $	��Top=�5�     $��35��5�     $	��113��5�     �� 5�  
   $
��Left=�6   $��
Answer B :��5�     $��629,232,0,0q�5�     
�������$��20(�5�     $��NSimSun)�5�     $ Center=�5�     $
��Wrap=�5�     $	��Top=�5�     $��35��5�     $	��113��5�     �� 5�  
   $
��Left=�6   $��
Answer C :��5�     $��629,300,0,0q�5�     
�������$��20(�5�     $��NSimSun)�5�     $ Center=�5�     $
��Wrap=�5�     $	��Top=�5�     $��35��5�     $	��113��5�     �� 5�  
   $
��Left=�6   $��
Answer D :��5�     $��	629,0,0,0q�5�     
�������$��20(�5�     $��NSimSun)�5�     $ Center=�5�     $
��Wrap=�5�     $��Center=�5�     $��26��5�     $	��113��5�     �� 5�  
   $
��Left=�6   $��Correct Answer :��5�     $��629,422,0,0q�5�     
�������$��20(�5�     $��NSimSun)�5�     $ Center=�5�     $
��Wrap=�5�     $	��Top=�5�     $��34��5�     $	��171��5�     5�     5�     