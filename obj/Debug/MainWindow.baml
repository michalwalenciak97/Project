   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � 
ResizeMode$  CanMinimize=�5   	    � Title$ PEKAPE��5	   	   $	��350��6   $	��640��6%   .��5
      � ��5   
   �� 5       j� Stretch$
 Fill=�6    �� ImageSource$ Image\bg1.jpg��6(    j� 
AlignmentY$	 Top=�5       j� 
AlignmentX$ Center=�6"   .+�5   
   �� -   5         ��Name$ textBox��5      $��2��6#   $
��Left=�63   $��23��6N   $��	41,94,0,0q�6Z   $��2��6m    �� TextWrapping$
 Wrap=�6z   $	��Top=�6�   $	��120��6�    J� RenderTransformOrigin$ 0.481,2.843&�6�   � 5   
   $��3��6   $��3��6#   .+�5      �� -   5        	 ��Name$	 label1��5      $��Rozklad Jazdy��6$   $
��Left=�6<   $��	27,21,0,0q�6W   $	��Top=�6j   $
��Bold"�6�   $��20(�6�   $ 0.284,0.643&�6�   
���   �6�   �� 5      -   5        $	 label1_Copy��5      $��	Odjazd z:��6)   $
��Left=�6=   $��	47,63,0,0q�6X   $	��Top=�6k   $
��Bold"�6�   
���   �$��14(�6�   $ 
0.88,0.478&�6�   �� 5      -   5        $	 label1_Copy1��5      $��Przyjazd do:��6*   $
��Left=�6A   $��
47,116,0,0q�6\   $	��Top=�6p   $
��Bold"�6�   
���   �$��14(�6�   �� 5      -   5        $ textBox_Copy��5      $
��Left=�6,   $��23��6G   $��
41,145,0,0q�6S   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   $ 0.481,2.843&�6�   �� 5      -   5        $	 label1_Copy2��5      $��Godzina odjazdu:��6*   $
��Left=�6E   $��
41,168,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   
���   �$��14(�6�   �� 5      -   5        $ textBox_Copy1��5      $
��Left=�6-   $��23��6H   $��
41,196,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   $ 0.481,2.843&�6�   �� 5      -   5        
 ��Name$
 button��5      $��Wyszukaj��6%   $
��Left=�68   $��
22,242,0,0q�6S   $	��Top=�6g   $��75��6   $ 0.934,0.425&�6�   &   System.Windows.Controls.Calendar  5      -	   5          Name$ 	calendar1��5      $
��Left=�6*   $��
199,92,0,0q�6E   $	��Top=�6Y   �� 5      -
   5        $	 label��5      $��Podaj datę:��6#   $
��Left=�69   $��
199,63,0,0q�6T   $	��Top=�6h   $��14(�6�   $
��Bold"�6�   �� 5      -   5        $
 button1��5      $��Pokaż��6&   $
��Left=�66   $��
540,98,0,0q�6Q   $	��Top=�6e   $��75��6}   6�   �� 5      -   5        $
 button2��5      $��Dodaj linie��6&   $
��Left=�6<   $��107,242,0,0q�6W   $	��Top=�6l   $��75��6�   6�   �� 5      -   5        $ textBox1��5      $
��Left=�6(   $��23��6C   $��
415,97,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5      -   5        $	 label2��5      $��Podaj nazwę przystanku��6$   $
��Left=�6E   $��
415,63,0,0q�6`   $	��Top=�6t   $
��Bold"�6�   $��14(�6�   �� 5      -   5        $	 label3��5      $#��Tablica przyjazdów/odjazdów��6$   $
��Left=�6J   $��
334,21,0,0q�6e   $	��Top=�6y   $��20(�6�   $
��Bold"�6�   $ 0.505,0.046&�6�   5      5       5!      