   M S B A M L   `   `   `  ����B  >P2P_TCP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:P2P_TCPP2P_TCP  5   	       P2P_TCP.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:P2P_TCP     5   	     � Title$?  9客户端登陆 - IM by 熊逸飞 & 程子齐 & 刘雨乔��5   	   $��233.041��67   $��386.8��6H    � 
ResizeMode$ NoResize=�6V    � WindowStartupLocation$ CenterScreen=�6l   .��5	      � .+�5
   
   �� -   5         ��Name$ 
textBox_id��5
      $
��Left=�6&   $��23��6A   $��
196,28,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��120��6�   $��Center=�6�   G� 5   
   -   5         G�Name$ passwordBox��5      $
��Left=�6+   $��23��6F   $��
196,64,0,0q�6R   $	��Top=�6f   $	��120��6~   $��Center=�6�   �� 5   
   -   5         ��Name$ textBlock_id��5      $
��Left=�6*   $��	76,33,0,0q�6E   $
��Wrap=�6X   $��请输入用户ID��6l   $	��Top=�6{   $��14(�6�   �� 5   
   -   5        $ textBlock_pw��5      $
��Left=�6*   $��	83,69,0,0q�6E   $
��Wrap=�6X   $��请输入密码��6l   $	��Top=�6y   $��14(�6�   �� 5   
   -   5        $ 
textBox_ip��5      $
��Left=�6&   $��23��6A   $��196,100,0,0q�6M   $
 Wrap=�6b   $��106.14.44.67:1248��6v   $	��Top=�6�   $	��120��6�   $��Center=�6�   �� 5   
   -   5        $ textBlock_ip��5      $
��Left=�6*   $��
60,105,0,0q�6E   $
��Wrap=�6Y   $��请输入服务器地址��6m   $	��Top=�6}   $��14(�6�   �� 5   
   -   5         ��Name$ button_register��5      $��注册账号��6*   $
��Left=�69   $��
60,146,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 5   
   -   5        $ button_login��5      $��登陆��6'   $
��Left=�64   $��150,146,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5   
   -	   5        $ button_about��5      $��关于��6'   $
��Left=�64   $��241,146,0,0q�6O   $	��Top=�6d   $��75��6|   6�   5      5      