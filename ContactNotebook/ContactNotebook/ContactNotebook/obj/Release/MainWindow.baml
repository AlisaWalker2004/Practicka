   M S B A M L   `   `   `  ���� J  FContactNotebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ContactNotebookContactNotebook       ContactNotebook.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:ContactNotebook       � Title$  Контакты��$	��500��$	��800�� � Icon$! /Resources/второй.ico��.���  � RowDefinitions �� $	��40* ��� $	��40* ��� $	��40* �.+�� $��1��.+��� ���	#FF7CFF6A�� -    ��Name$ 
lbReadText��$��1��$��Century Gothic)�$��22(�$y�Visible=����� *
fileRead+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� -   $��spAuto��$��0��$y�Hidden=�.+��� $"��Введите пароль:��$��Century Gothic)�$
��Wrap=�$��22(��� �� -    ��Name$ 
tbPassword��$��Century Gothic)� �� TextWrapping$
 Wrap=�$��22(�$	��220��$
��Left=��� �� -   $��
Войти�����	#FF7CFF6A$��Century Gothic)�$��20(�$
��Left=�� -   $��GridVis��$��2��$y�Hidden=� � ColumnDefinitions �� $��* ��� $��* ��� $��2* ��� $��* ��� $��* ��� $��* � �� �� .+��� -   $	��kab��$$��Введите кабинет:��$��Century Gothic)�$
��Wrap=�$��22(�$��Right=��� -   $��tbKab��$��1��$	��Top=�$��Century Gothic)�$
 Wrap=�$��22(��� -   $	��Fio��$6��0Введите ФИО или должность:��$��Century Gothic)�$
��Wrap=�$��22(�$��2��$��Right=��� -	   $��tbFio��$��3��$	��Top=�$��Century Gothic)�$
 Wrap=�$��22(��� -
   $��NumberPhone��$$��Введите телефон:��$��Century Gothic)�$
��Wrap=�$��22(�$��4��$��Right=��� -   $��tbNumberPhone��$��5��$	��Top=�$��Century Gothic)�$
 Wrap=�$��22(��� -   $��BtnSave��$��Сохранить��$��2��$��1�����	#FF7CFF6A$��Century Gothic)�$	��215��$��22(�$��49��$
��Left=��� -   $��BtnClear��$��Очистить поля��$��2��$��1��$��3�����	#FF7CFF6A$��Century Gothic)�$	��215��$��22(�$��49��$
��Left=��� -   $��BtnEdit��$ ��Редактировать��$y�Hidden=�$
��Left=����	#FF7CFF6A$��Century Gothic)�$	��215��$��22(�$��49���� -   $��BtnBack��$��Вернуться��$y�Hidden=����	#FF7CFF6A$��Century Gothic)�$	��215��$��22(�$��49��$��Right=��� -   $��	BtnDelete��$��Удалить��$y�Hidden=����	#FF7CFF6A$��Century Gothic)�$	��215��$��22(�$��49��$��Center=��� -   $��BtnEnter��$"��Авторизоваться��$y�Visible=����	#FF7CFF6A$��Century Gothic)�$	��215��$��22(�$��49��$��Right=�