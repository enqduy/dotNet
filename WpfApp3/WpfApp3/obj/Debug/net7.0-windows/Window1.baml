   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.Window1   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$
 dtg1��5
      $��Center=�6!   $	��150��6>   $��	0,217,0,0q�6K   $	��Top=�6^   $	��688��6v      AutoGenerateColumns$ False��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Ma benh nhan��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6E   �� *MaBn+  5      $ Ho ten��6%   $ * 65    6?   �� *HoTen+  5      $ Ma khoa��6%   $ * 66    6@   �� *MaKhoa+  5      $ Dia chi��6%   $ * 66    6@   �� *DiaChi+  5      $ So ngay nam vien��6%   $ * 6?    6I   �� *SoNgayNamVien+  5      $ Vien phi��6%   $ * 67    6A   �� *	VienPhi+5      �� 5   
   $��Ma benh nha��6   $
��Left=�6&   $��29��6A   $��	72,10,0,0q�6M   $	��Top=�6`   $��94��6x   �� 5   
   $��Ho ten��6   $
��Left=�6!   $��29��6<   $��	72,60,0,0q�6H   $	��Top=�6[   $��94��6s   �� 5   
   $��Dia chi��6   $
��Left=�6"   $��29��6=   $��	72,94,0,0q�6I   $	��Top=�6\   $��94��6t   �� 5   
   $��So ngay nam vien��6   $
��Left=�6+   $��29��6F   $��
72,128,0,0q�6R   $	��Top=�6f   $	��121��6~   �� 5   
   $��	Khoa kham��6   $
��Left=�6$   $��29��6?   $��
72,162,0,0q�6K   $	��Top=�6_   $��94��6w   �� 5   
   -   5         ��Name$ txtMa1��5      $��Center=�6"   $��32��6?   $��0,10,0,0q�6K    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��300��6�   �� 5   
   -   5        $ txtTen1��5      $��Center=�6#   $��32��6@   $��0,57,0,0q�6L   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��300��6�   �� 5   
   -   5        $ 
txtDiachi1��5      $��Center=�6&   $��32��6C   $��0,92,0,0q�6O   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��300��6�   �� 5   
   -   5        $ txtSo1��5      $��Center=�6"   $��32��6?   $��	0,129,0,0q�6K   $
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��300��6�   �� 5   
   -   5        	 ��Name$
	 cbb1��5      $��Center=�6!   $��36��6>   $��	0,166,0,0q�6J   $	��Top=�6]   $	��300��6u   5      5      