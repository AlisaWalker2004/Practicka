   M S B A M L   `   `   `  ����J  FContactNotebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ContactNotebookContactNotebook  5   	        ContactNotebook.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:ContactNotebook     5   	     � Title$  Контакты��5   	   $	��450��6   $	��800��6'    � Icon$! /Resources/второй.ico��63   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��30* �6   �� 5      $	��40* �6   �� 5      $	��40* �6   .+�5   
   �� -   5         ��Name$ 
lbReadText��5   N   $��1��6   $y�Visible=�6b   �� 5   
   -   5        $��spAuto��5   "   $��1��6   $y�Hidden=�60   .+�5      �� $"��Введите пароль:��6   $��Century Gothic)�6/   $
��Wrap=�6K   $��22(�6_   �� 5      �� 5      -   5         ��Name$ 
tbPassword��5      $��Century Gothic)�6*    �� TextWrapping$
 Wrap=�6F   $��22(�6Z   $	��220��6h   $
��Left=�6t   �� 5      �� 5      -   5        $��
Войти��5      ���	#FF7CFF6A$��Century Gothic)�6R   $��20(�6n   $
��Left=�6|   5      � 5   
   -   5        $��GridVis��5      $��2��6   $y�Hidden=�6+    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��2* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5       �� -   5        $	��kab��5    0   $$��Введите кабинет:��6   $��Century Gothic)�6;   $
��Wrap=�6W   $��22(�6k   $��Right=�6y   �� 5!      -   5        $��tbKab��5!   &   $��1��6   $	��Top=�63   $��Century Gothic)�6L   $
 Wrap=�6h   $��22(�6|   �� 5"      -   5        $	��Fio��5"   :   $6��0Введите ФИО или должность:��6   $��Century Gothic)�6E   $
��Wrap=�6a   $��22(�6u   $��2��6�   $��Right=�6�   �� 5#      -	   5        $��tbFio��5#   &   $��3��6   $	��Top=�63   $��Century Gothic)�6K   $
 Wrap=�6g   $��22(�6{   �� 5$      -
   5        $��NumberPhone��5$   0   $$��Введите телефон:��6   $��Century Gothic)�6C   $
��Wrap=�6_   $��22(�6s   $��4��6�   $��Right=�6�   �� 5%      -   5        $��tbNumberPhone��5%   &   $��5��6   $	��Top=�6;   $��Century Gothic)�6S   $
 Wrap=�6o   $��22(�6�   5&      �� 5'   
   -   5        $��BtnEnter��5'   B   $"��Авторизоваться��6   ���	#FF7CFF6A$��Century Gothic)�6i   $	��215��6�   $��22(�6�   $��Right=�6�   $��Center=�6�   $��49��6�   $��	585,0,0,0q�6�   �� 5(   
   -   5        $��BtnSave��5(   O   $��Сохранить��6   $y�Hidden=�6%   ���	#FF7CFF6A$��Century Gothic)�6u   $	��215��6�   $��22(�6�   $��Center=�6�   $��49��6�   $
��Left=�6�   �� 5)   
   -   5        $��BtnBack��5)   P   $��Вернуться��6   $y�Hidden=�6<   ���	#FF7CFF6A$��Century Gothic)�6v   $	��215��6�   $��22(�6�   $��Center=�6�   $��49��6�   $��Center=�6�   5+      5,      