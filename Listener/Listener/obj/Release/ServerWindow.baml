   M S B A M L   `   `   `  ���� C  ?Listener, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ListenerListener      Listener.ServerWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Listener       � Title$?  9服务端登陆 - IM by 熊逸飞 & 程子齐 & 刘雨乔��$��247.974��$��430.8�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��]� ��. .+�o� -    o�Name$
 menu��$��Center=�$	��Top=�.@�m� -   $��MenuItem_File��$��
文件(_F)�� m� InputGestureText$ Ctrl+F��.@�m� -   $!��账号信息保存到文件��$
��Left=�m� -   $!��从文件导入账号信息��$
��Left=�m� -   $��MenuItem_Exit��$��
退出(_E)��$ Ctrl+E��m� -   $��MenuItem_About��$��
关于(_A)��$ Ctrl+A���  � ColumnDefinitions �� $
��137* ��� $
��244* �.+��� -    ��Name$ 
textBlock3��$
��Left=�$��
41,168,0,0q�$
��Wrap=�$��本机IP地址:��$	��Top=�$	��323�� �� TextAlignment$ Center=�$��2���� -    ��Name$ button_StartServer��$��运行��$
��Left=�$��
53,128,0,0q�$	��Top=�$��75���� -	   $
 port��$
��Left=�$��	17,51,0,0q�$
��Wrap=�$<��6请输入用于用户登录的端口号(1024-65535)：��$	��Top=�$��89���� -
   	 ��Name$	 portText��$
��Left=�$��23��$��
116,53,0,0q�
 �� TextWrapping$

 Wrap=�$
��1500��$	��Top=�$��55��$��Center=�$��Center=�$��2���� -   $ 	textBlock��$
��Left=�$��71.2,57,0,0q�$
��Wrap=�$��群聊端口号��$	��Top=�$��1���� -   $	 textBox��$
��Left=�$��23��$��144.2,51,0,0q�$

 Wrap=�$�� ��$	��Top=�$��86��$��1���� -   $ button��$��添加群聊��$
��Left=�$��125.2,128,0,0q�$	��Top=�$��75��$��1���� -   $ 
textBlock1��$��1��$
��Left=�$��60.2,80,0,0q�$
��Wrap=�$��已添加群聊端口:��$	��Top=�$��43��$	��189��