   M S B A M L   `   `   `  ����>  :APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:APPAPP  5   	       APP.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:APP     5   	     � Title$  Check your loan��5   	   $	��575��6!   $	��800��6.    � 
ResizeMode$ NoResize=�5	   	   .��5
      � 
�������$��0,0,0,0q�6!   .+�5   
   �� 
���   �$��1q�6%   $
��Left=�69   $��41��6T   $��	72,23,0,0q�6`   $	��Top=�6s   $	��328��6�   
������� � 	Resources 5       �� 
TargetType �� Property �� Value��%d   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 10��65   6B   5      5      ._�5      � .+�5      �� $
��Left=�6   $
��auto��63   $��Center=�6A   $
��auto��6\   
�������$��30,0,0,0q�6z   .��6�   Your wallet's value:6�   �� 5      -   5         ��Name$ Money��5      $
��Left=�6)   $
��auto��6D   $��Center=�6R   $
��auto��6m   $��	150,0,0,0q�6z   
�������6�   5      5      �� 5   
   
���   �
�������$��1q�6<   $
��Left=�6P   $��41��6k   $��
448,23,0,0q�6w   $	��Top=�6�   $	��280��6�    5      ��%k   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 	10,10,0,0��65   6I   5      5      ._�5      �� $
��MENU��6   $��Center=�6#   $
��auto��6@   $��Center=�6N   $
��auto��6i   $��16(�6v   $��Oblique$�6�   $
��Bold"�6�   5      �� 5   
   
���   �
�������$��1q�6<   $
��Left=�6P   $��41��6k   $��	72,87,0,0q�6w   $	��Top=�6�   $	��164��6�    5       ��%j   '��       �� 5!      " ��6   .�5"      ��  �@��CornerRadius$ 10,0,0,0��65   6H   5#      5$      ._�5%      �� $��Loans in plus��6   $��Center=�6,   $
��auto��6I   $��Center=�6W   $
��auto��6r   $��16(�6   $��Oblique$�6�   $
��Bold"�6�   5&      �� 5'   
   
���   �
�������$��1q�6<   $
��Left=�6P   $��41��6k   $��
236,87,0,0q�6w   $	��Top=�6�   $	��164��6�    5(      ��%j   '��       �� 5)      " ��6   .�5*      ��  �@��CornerRadius$ 0,10,0,0��65   6H   5+      5,      ._�5-      �� $��Loans in minus��6   $��Right=�6-   $
��auto��6I   $��Center=�6W   $
��auto��6r   $��16(�6   $��Oblique$�6�   $
��Bold"�6�   $��0,0,20,0q�6�   5.      �� 5/   
   
���   �$��1q�6%   $
��Left=�69   $	��400��6T   $��
72,128,0,0q�6a   $	��Top=�6u   $	��164��6�   ._�50      �� -   5        $ GrantedList��50      $
��Left=�6+   $	��400��6F   $��0,0,0,0q�6S   $	��Top=�6d   $	��164��6|   
�������6�   52      �� 53   
   
���   �$��1q�6%   $
��Left=�69   $	��400��6T   $��236,128,0,0q�6a   $	��Top=�6v   $	��164��6�   ._�54      �� -   5        $ ObtainsList��54      $��Center=�6+   $	��400��6H   $��Center=�6U   $	��164��6p   
�������6|   56      �� 57   
   
���   �$��1q�6%   $
��Left=�69   $	��223��6T   $��
448,64,0,0q�6a   $	��Top=�6u   $	��280��6�   ._�58      � 
�������$��1,1,1,1q�6*   .+�59      �� -   5         ��Name$ B1��59      $��Add Payment��6%   
�������$��Center=�6L   $��25��6i   $��0,5,0,0q�6u   $	��Top=�6�   $	��250��6�   6�   �� 5:      -   5        $ B2��5:      $��Erase Payment��6%   
�������$��Center=�6N   $��25��6k   $��0,35,0,0q�6w   $	��Top=�6�   $	��250��6�   6�   �� 5;      -   5        $ B3��5;      $��Simulate��6%   
�������$��Center=�6I   $��25��6f   $��0,65,0,0q�6r   $	��Top=�6�   $	��250��6�   6�   �� 5<      -   5        $ B4��5<      $��Add Contact��6%   
�������$��Center=�6L   $��25��6i   $��0,95,0,0q�6u   $	��Top=�6�   $	��250��6�   6�   �� 5=      -   5        $ B5��5=      $��Erase Contact��6%   
�������$��Center=�6N   $��25��6k   $��	0,125,0,0q�6w   $	��Top=�6�   $	��250��6�   $��2��6�   �� 5>      -	   5        $ B6��5>      $��Notification��6%   
�������$��Center=�6N   $��25��6k   $��	0,155,0,0q�6w   $	��Top=�6�   $	��250��6�   $��2��6�   �� 5?      -
   5        $ B7��5?      $��My data��6%   
�������$��Center=�6I   $��25��6f   $��	0,185,0,0q�6r   $	��Top=�6�   $	��250��6�   6�   5@      5B      �� 5C   
   
���   �
�������$��1q�6<   $
��Left=�6P   $��40��6k   $��448,308,0,0q�6w   $	��Top=�6�   $	��280��6�    5D      ��%k   '��       �� 5E      " ��6   .�5F      ��  �@��CornerRadius$ 	10,10,0,0��65   6I   5G      5H      ._�5I      �� $��CONTACTS��6   $��Center=�6'   $
��auto��6D   $��Center=�6R   $
��auto��6m   $��16(�6z   $��Oblique$�6�   $
��Bold"�6�   5J      �� 5K   
   
���   �$��1q�6%   $
��Left=�69   $	��180��6T   $��448,348,0,0q�6a   $	��Top=�6v   $	��280��6�   ._�5L      �� -   5        $ ContactsList��5L      $��0,0,0,0q�6-   
�������6>   5M      5P      5Q      