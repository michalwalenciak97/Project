   M S B A M L   `   `   `  ���� B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1      WpfApp1.Window2   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:WpfApp1       � 
ResizeMode$  CanMinimize=� � Title$ Dodawanie linii��$	��350��$	��700��.��� ����  j� Stretch$
 Fill=� �� ImageSource$ Image\bg1.jpg�� j� 
AlignmentY$	 Top=� j� 
AlignmentX$ Center=�.+��� -    ��Name$ label��$��Przystanek:��$
��Left=�$��	10,26,0,0q�$	��Top=�$
��Bold"��� -   $ label1��$��Numer pociągu:��$
��Left=�$��	10,88,0,0q�$	��Top=�$
��Bold"��� -   $ label2��$��Godzina odjazdu:��$
��Left=�$��
10,150,0,0q�$	��Top=�$
��Bold"��� -   $ label3��$��Godzina przyjazdu:��$
��Left=�$��
10,212,0,0q�$	��Top=�$
��Bold"��� -   $ label4��$��Peron:��$
��Left=�$��
159,26,0,0q�$	��Top=�$
��Bold"��� -   $ label5��$
��Tor:��$
��Left=�$��
159,88,0,0q�$	��Top=�$
��Bold"��� -   $ label6��$��Data:��$
��Left=�$��
299,26,0,0q�$	��Top=�$
��Bold"� J� RenderTransformOrigin$ -0.35,0.462&��� -    ��Name$ textBox��$
��Left=�$��23��$��	10,52,0,0q�	 �� TextWrapping$
	 Wrap=�$	��Top=�$	��120���� -	   $ textBox1��$
��Left=�$��23��$��
10,114,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -
   $ textBox2��$
��Left=�$��23��$��
10,176,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -   $ textBox3��$
��Left=�$��23��$��
10,238,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -   $ textBox4��$
��Left=�$��23��$��
159,52,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -   $ textBox5��$
��Left=�$��23��$��159,114,0,0q�$
	 Wrap=�$	��Top=�$	��120��&   System.Windows.Controls.Calendar  -   
  Name$
 calendar��$
��Left=�$��
299,52,0,0q�$	��Top=��� -    ��Name$ button��$��Dodaj przystanek��$
��Left=�$��159,229,0,0q�$	��Top=�$	��120��$��32���� -   $ label7��$��Dodawanie przystanku:��$
��Left=�$��10,4,0,0q�$	��Top=�$ 0.474,0.423&�$
��Bold"�$��16(��� -   $ label8��$��Dodawanie pociągu:��$
��Left=�$��	498,4,0,0q�$	��Top=�$
��Bold"�$��16(��� -   $ label9��$��Numer:��$
��Left=�$��
498,26,0,0q�$	��Top=�$
��Bold"��� -   $ textBox6��$
��Left=�$��23��$��
498,52,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -   $ label10��$��Nazwa:��$
��Left=�$��
498,88,0,0q�$	��Top=�$
��Bold"��� -   $ textBox7��$
��Left=�$��23��$��498,114,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -   $ label11��$��Rodzaj:��$
��Left=�$��498,150,0,0q�$	��Top=�$
��Bold"��� -   $ textBox8��$
��Left=�$��23��$��498,176,0,0q�$
	 Wrap=�$	��Top=�$	��120���� -   $ button1��$��Dodaj pociąg��$
��Left=�$��498,229,0,0q�$	��Top=�$	��120��$��32��