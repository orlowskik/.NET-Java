   M S B A M L   `   `   `  ����>  :APP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:APPAPP  5   	       APP.SimulateWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:APP     5   	     � Title$  SimulateWindow��5   	   $	��487��6    $	��858��6-    � 
ResizeMode$ NoResize=�5	   	   .��5
      � 
�������$��0,0,-16,-31q�6!   .+�5   
   �� -   5        $��Simulate��5      $
��Left=�6$   $��32��6?   $��621,348,0,0q�6K   $	��Top=�6`   $	��112��6x   $��2��6�   �� 5   
   -   5        $
��Exit��5      $
��Left=�6    $��34��6;   $��422,348,0,0q�6G   $	��Top=�6\   $	��112��6t   6�   �� 5   
   -   5        $��Check��5      $
��Left=�6!   $��34��6<   $��507,208,0,0q�6H   $	��Top=�6]   $	��150��6u   6�   �� 5   
   
���   �
�������$��1q�6<   $
��Left=�6P   $��41��6k   $��	90,73,0,0q�6w   $	��Top=�6�   $	��280��6�    � 	Resources 5       �� 
TargetType �� Property �� Value��%k   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 	10,10,0,0��65   6I   5      5      ._�5      �� $��CONTACTS��6   $��Center=�6'   $
��auto��6D   $��Center=�6R   $
��auto��6m   $��16(�6z   $��Oblique$�6�   $
��Bold"�6�   5      �� 5   
   
���   �$��1q�6%   $
��Left=�69   $	��266��6T   $��
90,114,0,0q�6a   $	��Top=�6u   $	��280��6�   ._�5      �� -   5         ��Name$ ContactsList2��5      
����������	#FF050505$	��266��6]   $��Center=�6j   $��Center=�6�   $	��280��6�   5      �� 5   
   $��1q�6   
���   �$	��156��69   $
��Left=�6E   $	��Top=�6a   $��400,284,0,0q�6y   
�������._�5      �� -   5        $��NameTextBox��5      $��Center=�6+   $
��Wrap=�6I   $��It sums:��6]   $��Center=�6m    �� TextAlignment$ Center=�6�   
�������6�   5      �� 5   
   -   5        $��	YouPayBox��5      $
��Left=�6#   $��19��6>   $��601,162,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $
�� ---��6s   $	��Top=�6   $	��150��6�   	 �� TextAlignment$	 Center=�6�   
�������$��2��6�   �� 5   
   -   5        $��YouReceiveBox��5      $
��Left=�6'   $��18��6B   $��399,162,0,0q�6N   $
 Wrap=�6c   $	��+++��6w   $	��Top=�6�   $	��150��6�   $	 Center=�6�   
�������6�   �� 5    
   $��1q�6   
���   �$��80��69   $��26��6D   $
��Left=�6P   $	��Top=�6k   $��636,122,0,317q�6�   
�������$��2��6�   ._�5!      �� -   5        
 ��Name$
 
textBlock1��5!      $��Center=�6.   $
��Wrap=�5"      $��Center=�5#      ���	#FF111111$ Center=�6J   
��������� 6y   $�You Pay��6}   �� 6�    � Language$ pl-pl�6�   $�:��6�   6�   5$      �� 5%   
   $��1q�6   
���   �$��80��69   $��26��6D   $
��Left=�6P   $	��Top=�6k   $��437,122,0,317q�6�   
�������._�5&      �� -	   5        $
 
textBlock2��5&      $��Center=�6.   $
��Wrap=�5'      $��Center=�5(      ���	#FF111111$ Center=�6J   �� 6c   $�You Receive��6g   
�������6z   �� 6�   $ pl-pl�6�   $�:��6�   6�   5)      �� 5*   
   -
   5         ��Name$ SumBox��5*      $
��Left=�6"   $��19��6=   $��601,284,0,0q�6I   $
 Wrap=�6^   $��0��6r   $	��Top=�6{   $	��150��6�   $	 Center=�6�   
�������6�   5,      5-      