   M S B A M L   `   `   `  ����J  FDocumentManager, Version=0.0.0.1, Culture=neutral, PublicKeyToken=nullG(clr-namespace:DocumentManager.PropertiesDocumentManager.Properties  5      =#clr-namespace:DocumentManager.ViewsDocumentManager.Views  5      *    $DocumentManager.Views.RepositoryView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >	resources(clr-namespace:DocumentManager.Properties     5      5views#clr-namespace:DocumentManager.Views     5      T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5        � DataContext  5
      �� *RepositoryInstance+   Locator �� Source# [   � 	Resources 5        	TextStyle �� 
TargetType �� Property �� Value }� Location }� 	PenOffset
 }� Pen	 >� Brush
 >� 	Thickness��%�   &	       �� 5   
   " ��6"   .�5      ��  � �� 5      |� 5      }� 5      $ 	Underline=�6)   $ 3Q�6>    5      >� 5   "   	 �#41B1E1$
 2Q�66   5      5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5        � ColumnDefinitions 5"   
   �� 5#      $
��Auto �6   �� 5$      $��* �6   .+�5&   
   �� $��2��6   $��5,0,0,0q�6(   $��List of Documents��6:   #��[ 6S   � 5'   
   $��1��6   $��0��6   $��0,5,0,0q�6,    5(      �� 5)      $
��Auto �6    �� 5*      $��* �6    .+�5,      �� $��
Repository��6   .��5-      �  5.      �� 5/      $
��Auto �6(   �� 50      $
��Auto �6(   �� 51      $
��Auto �6(   .+�54      ��  �� SelectedIndex$ 0��6y   ��6   �� *RepositoriesListCollection+ �� SelectedItem 6Q   �� *SelectedFolder+ 55        RepositoryIcon �� 	UriSource��%8   &	       �� 56      $ ../Images/Folder.png?�6A   57      ��58      �� 59      " ��6$    �� Triggers 5:   "   P� 5;   &    P� Property �@��
IsSelected P� Value . . �5<   *   ��  � ��
 ��·�6G   5=   '   5?      ��5A      �� 5B      .R�5C   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5D   &   �� #��[ 6,   �� 5E   &   ��60   �� *RepositoryName+5F   #   5G      5I      �� 5J      $��1��6   $��1q�6,   $��Add New Repository��6@   $��0,5,0,0q�6\   .��5K      �  5L      �� 5M   "   $��* �63   �� 5N   "   $
��Auto �63   .+�5P      �� *   $DocumentManager.Properties.Resources   
FolderName*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark# Z 6E   ��6&   �� *NewFolderName+6�   �� 5Q      $��0��6%   $��1��62   $��5,0,0,0q�6B   $��75��6S   
   Add � ToolTip# Z 6^   #��Z 6�   ��6�   �� *
AddCommand+6�   5S      5U      � 5W      $��2��6   $��0,5,0,0q�6(   .+�5X      ��    Delete# Z 6!   #��Z 6Q   $	��100��6�   $
��Left=�6�   $��25��6�   ��6�   �� *DeleteCommand+6�   �� 5Y         Edit# Z 6!   #��Z 6P   $	��100��6~   $��25��6�   $��Right=�6�   ��6�   �� *EditCommand+6�   5Z      5[      5\      �� 5]      $��1��6      Models#��Z 6$   .��5^      �  5_      �� 5`      $
��Auto �6(   �� 5a      $��* �6(   .+�5d      � .+�5e      ,   &DocumentManager.Views.FolderModelsView  63   5f      �� 5h      $��1��6   $��Bottom=�6*   # Z 6E   $��25��6r      	OpenModel#��Z 6�   ��6~   �� *
AddCommand+5i      5j      5k      5l      � 5m   
   $��1��6   $��1��6   .+�5n      (   "DocumentManager.Views.DocumentView  6#   5o      �� 5p   
   $
��Find��6   $��2��6!   $��0��6.   $��2��6>   .��5q      �  5r      �� 5s      $
��Auto �6$   64   �� 5t      $��10 �6$   �� 5u      $
��Auto �6$   �� 5v      $��10 �6$   �� 5w      $
��Auto �6$    5y      �� 5z      $��* �6'   �� 5{      $
��Auto �6'   .+�5}      ��    
SearchText# Z 66   ��6   �� *
FilterText+6�   �� 5~      $��0��6   $��1��6&   $��5,0,0,0q�66   $	��200��6G      Find# Z 6S   #��Z 6�   ��6�   �� *FindCommand+6�   �� 5      $��0��6   $��2��6+      FindByFolder#��Z 68   6q   �� 5�      $��0��6   $��4��6+      
FindByFile#��Z 68   6o   5�      5�      5�      5�      