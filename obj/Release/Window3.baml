   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.Window3   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � 
ResizeMode$  CanMinimize=� � Title$ Window3��$	��400��$	��800��.���  � ColumnDefinitions �� $��9* ��� $
��227* �.+��� -   $��lblTime��$��24(�$��Center=�$��Center=� J� RenderTransformOrigin$ 	-0.6,-7.4&�$��1��$��222,10,245,316q�$��43��$	��102��$��00:00:00���� -   $��lstTrain��$��10,100,400,10q�$��2�� �� View ��  �� AllowsColumnReorder . P��� $��Z�� �� DisplayMemberBinding �� *Place_Start+�� $��Godz. przyjazdu�� �� *Time_arrival+�� $��Peron�� �� *
Platform+�� $	��Tor�� �� *Track+�� $��Numer�� �� *Train+�� -    ��Name$ lstTrain_Copy��$��372,100,8,10q�$��1�� ��  . .P��� $��Do�� �� *	Place_End+�� $��Godz. odjazdu�� �� *Time_departure+�� $��Peron�� �� *
Platform+�� $	��Tor�� �� *Track+�� $��Numer�� �� *Train+�� -    ��Name$ label��$�� ��$
��Left=�$��	10,10,0,0q�$	��Top=�$��2��$
��Bold"�$��14(��� -   	 ��Name$	 textBox��$��1��$
��Left=�$��23��$��
552,41,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��120���� -    ��Name$ button��$��Zmień��$��1��$
��Left=�$��
677,44,0,0q�$	��Top=�$��75���� -   $ label1��$��Zmiana stacji��$��1��$
��Left=�$��
552,10,0,0q�$	��Top=�$
��Bold"�$��16(��� -   $ label2��$��Podaj nazwę stacji:��$��1��$
��Left=�$��
431,38,0,0q�$	��Top=�$
��Bold"��� -	   $ label3��$��Przyjazd��$
��Left=�$��	10,64,0,0q�$	��Top=�$
��Bold"�$��16(�$��2���� -
   $ label4��$��Odjazd��$��1��$
��Left=�$��
372,64,0,0q�$	��Top=�$��16(�$
��Bold"�