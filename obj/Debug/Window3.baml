   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Window3   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ Window3��5	   	   $	��400��6   $	��800��6&   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��9* �6   �� 5      $
��227* �6   .+�5   
   �� -   5        $��lblTime��5      $��24(�6   $��Center=�6-   $��Center=�6J    J� RenderTransformOrigin$ 	-0.6,-7.4&�6e   $��1��6�   $��222,10,245,316q�6�   $��43��6�   $	��102��6�   $��00:00:00��6�   �� 5   
   -   5        $��lstTrain��5      $��10,100,400,10q�6#   $��2��6:    �� View 5      �� 5       �� AllowsColumnReorder . P�5      �� 5      $��Z��6)    �� DisplayMemberBinding 5      �� *Place_Start+�� 5      $��Godz. przyjazdu��6)    5      �� *Time_arrival+�� 5      $��Peron��6)    5      �� *
Platform+�� 5      $	��Tor��6)    5      �� *Track+�� 5      $��Numer��6)    5      �� *Train+5      5!      �� 5"   
   -   5         ��Name$ lstTrain_Copy��5"      $��372,100,8,10q�6*   $��1��6@    5#      �� 5$       . .P�5%      �� $��Do��6%    5&      �� *	Place_End+�� 5'      $��Godz. odjazdu��6%    5(      �� *Time_departure+�� 5)      $��Peron��6%    5*      �� *
Platform+�� 5+      $	��Tor��6%    5,      �� *Track+�� 5-      $��Numer��6%    5.      �� *Train+5/      51      �� 52   
   -   5         ��Name$ label��52      $�� ��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $��2��6p   $
��Bold"�6�   $��14(�6�   �� 53   
   -   5        	 ��Name$	 textBox��53      $��1��6#   $
��Left=�63   $��23��6N   $��
552,41,0,0q�6Z   
 �� TextWrapping$

 Wrap=�6n   $	��Top=�6�   $	��120��6�   �� 54   
   -   5         ��Name$ button��54      $��Zmień��6!   $��1��61   $
��Left=�6A   $��
677,44,0,0q�6\   $	��Top=�6p   $��75��6�   6�   �� 55   
   -   5        $ label1��55      $��Zmiana stacji��6    $��1��68   $
��Left=�6H   $��
552,10,0,0q�6c   $	��Top=�6w   $
��Bold"�6�   $��16(�6�   �� 56   
   -   5        $ label2��56      $��Podaj nazwę stacji:��6    $��1��6>   $
��Left=�6N   $��
431,38,0,0q�6i   $	��Top=�6}   $
��Bold"�6�   �� 57   
   -	   5        $ label3��57      $��Przyjazd��6    $
��Left=�63   $��	10,64,0,0q�6N   $	��Top=�6a   $
��Bold"�6y   $��16(�6�   $��2��6�   �� 58   
   -
   5        $ label4��58      $��Odjazd��6    $��1��61   $
��Left=�6A   $��
372,64,0,0q�6\   $	��Top=�6p   $��16(�6�   $
��Bold"�6�   59      5:      