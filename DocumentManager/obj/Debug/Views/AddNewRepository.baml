   M S B A M L   `   `   `  ����  DocumentManager,    &DocumentManager.Views.AddNewRepository   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   T PMahApps.Metro, Version=1.1.2.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	      AccentColorBrush(  "MahApps.Metro.Controls.MetroWindow    	GlowBrush#  �   5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ New Repository��5   	   $	��120��6    $	��400��6-    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ ../Skins/MainSkin.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��5 �6   .+�5   
   �� $��1��6   $��Repository name :��6   
��� d �$��14(�6P   6`   �� 5   
   -   5        $��FolderTextBox��5   K   $��1��6   $��1��6   ��6/   �� *
FolderName+6b   �� 5   
   -   5        $��2��5      $��1��6   $��Ok��6.   $��25��6;   $
��Left=�6`   $	��100��6{   6�   �� 5   
   -   5        $��2��5      $��1��6   $��Cancel��6.   $��25��6@   $��Right=�6c   $	��100��6   6�   5      5       