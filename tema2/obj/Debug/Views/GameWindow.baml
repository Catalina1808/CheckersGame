   M S B A M L   `   `   `  ����@  <tema2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:tema2.ViewModelstema2.ViewModels  5   	       tema2.Views.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:tema2.ViewModels     5   	     � Title$  Game Window��5   	   $��627.913��6   $��538.56��6.   ���	#FF7F432B � DataContext 5	        tema2.ViewModels.GameVM  5
   
   .��5      � $��Center=�6   .+�5   
   �� $��Center=�6X   $��Bottom=�6u   $��22(�6�   ���	#FF380C0C$��109,0,128,50.4q�6�   ��6   �� *Bl.NextPlayer+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   -   5        $
��grid��5      $��Center=�6E   $��Center=�6b   $	��483��6}   $��5,4,9,111.4q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��6#   �� *	GameBoard+z�5      V� 5      .~�5      �� �� 5      �� 5       �� Angle$ 0.027Q�6&   T� 5      5      ��5      �� 5      .R�5      �� ��6#   �� ��5      �� 5      .R�5   "   ��  �� Orientation$ 
Horizontal=�6-   5      ��5      �� 5       .R�5!   "   �� $��65��6)   $��60��64   $��2q�6@   ���	#FF5F2C17._�5"   &   �� ��6-   �� *ClickCommand+��6N   �� *
SimpleCell+��5#   *   �� 5$   .   .R�5%   2   �� $��UniformToFill=�6^   ��68   �� *SimpleCell.Display+6^   5&   /   5(   '   5)   #   5*      5,      5-      5/      �� 50   
   -   5         ��Name$ btn_back��50      $��Inapoi��6#   $
��Left=�64   $��401,500,0,0q�6O   $	��Top=�6d   $��97��6|   $��MV Boli)�6�   $��16(�6�   $��30��6�   ���	#FFEBC4B4$ 0.5,0.5&�6�    J� Effect 51      3  -System.Windows.Media.Effects.DropShadowEffect  52      ��54      �� 55       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��56      � 
 � Color$
 	#FF7D462F��6#    � Offset$ 0.311Q�65   � 57      $
 	#FF572D1C��6#   $	 0.7Q�65   58      z�5:      V� 5;      .~�5<      �� �� 5=       �� AngleX$ -11.71Q�6$   �� 5>      T� 5?       T� X$ 3.835Q�6)   5@      5B      �� 5C   
   -   5        $ btn_save��5C      $��Salvare joc��6m   $
��Left=�6�   $��394,539,0,0q�6�   $	��Top=�6�   $	��107��6�   $��MV Boli)�6�   $��16(�6�   $��30��6�   ���	#FFEBC4B4$ 0.5,0.5&�6  ��6$   �� *SerializationCommand+��6M   �� *Bl+ 5D        5E      ��5G      �� 5H      $ 0.5,1&�6&   $	 0.5,0&�67   .��5I      � $
 	#FF7D462F��6#   $ 0.311Q�65   � 5J      $
 	#FF572D1C��6#   $	 0.7Q�65   5K      z�5M      V� 5N      .~�5O      �� �� 5P      $ -11.71Q�6$   �� 5Q      T� 5R      $ 3.835Q�6)   5S      5U      5W      5Y      