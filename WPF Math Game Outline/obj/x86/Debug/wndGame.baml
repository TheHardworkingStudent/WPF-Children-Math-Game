   M S B A M L   `   `   `  ����  WPF Math Game Outline#    WPF_Math_Game_Outline.wndGame   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  wndGame��5   	   $	��342��6   $	��598��6&   ��5      �� 5   
    �� ImageSource$! Images\robloxcrossroads.jpg��6    j� Stretch$ UniformToFill=�6?   5      .��5	      �  � RowDefinitions 5
   
   �� 5      $	��42* �6   �� 5      $
��121* �6   .+�5   
   �� -   5         ��Name$ StartGameButton��5   o   $��
Start Game��6   $��18(�6&   $��45��64   $��Center=�6@   $��0,79,0,0q�6]   $	��Top=�6�   $	��198��6�   ���	#FF232527
�������$��1��6�   �� 5   
   -   5        $��cmdFinalScoreScreen��5   x   $��Final Score Screen��6   $��18(�6.   $��45��6<   $��Center=�6H   $��	0,129,0,0q�6e   $	��Top=�6�   $	��198��6�   ���	#FF232527
�������$��1��6  �� 5   
   -   5         ��Name$ QuestionCounterLabel��5      $��
Question 1��6.   $
��Left=�6C   $��
228,34,0,0q�6^   $	��Top=�6r   ���	#FF232527
�������6�   �� 5   
   -   5         ��Name$ AnswerTextBox��5      $
��Left=�6)   $��
304,80,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $�� ��6l   $	��Top=�6t   $	��120��6�   $��2��6�   �� 5   
   -   5        $ 
TimerLabel��5      $��Time Elapsed: 0��6$   $
��Left=�6>   $��	55,76,0,0q�6Y   $	��Top=�6l   ���	#FF232527
�������$��2��6�   �� 5   
   -   5        $ ReturnMenuButton��5   u   $��Return Main Menu��6   $��18(�6,   $��45��6:   $��Center=�6F   $��0,79,0,0q�6c   $	��Top=�6�   $	��198��6�   $y�Hidden=�6�   ���	#FF232527
�������$��1��6  �� 5   
   -   5        $ QuestionContentLabel��5      $�� ��6.   $��221,73,294,0q�69   $	��Top=�6O    J� RenderTransformOrigin$ 1.277,0.685&�6g   ���	#FF232527
�������$��2��6�   �� 5   
   -   5        $ SubmitAnswerButton��5      $��Submit��6-   $
��Left=�6>   $��
429,79,0,0q�6Y   $	��Top=�6m   ���	#FF232527
�������$��2��6�   5      5      