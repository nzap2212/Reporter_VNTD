   M S B A M L   `   `   `  ����G  CReporter_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Reporter_wpf.ViewModelsReporter_wpf.ViewModels  5      )    #Reporter_wpf.Views.KetQuaNoiTruView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      <
viewmodels%clr-namespace:Reporter_wpf.ViewModels     5        � DataContext  5      3   -Reporter_wpf.ViewModels.KetQuaNoiTruViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $(��"Kết quả nội trú theo tháng��6      
TitleStyle#��[  5      $��0��5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ KetQuaNoiTruDataGrid��5      $��1��5        ModernDataGrid#��[ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5        DataGridCellStyle   	CellStyle# [ 5        DataGridRowStyle   RowStyle# [ 5         AutoGenerateColumns$ False��5         
IsReadOnly$ False��5      ��5      �� *KetQuaNoiTruData+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 STT��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 5    %      
IsReadOnly$
 True��5!   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *STT+5!   %     5"      $	 	Tên khoa��6%   $
 * 5$   %   $
 True��5%   %    5#   %   �� *	TenKhoa+5%   %     5(      $	 KH chỉ tiêu��6%   $	
 100 5*   %    5)   %   �� *KeHoach_chitieu+   ElementStyle 5+      �� 5,       �� 
TargetType" ��6    .�5-      ��  �� Property �@��TextAlignment �� Value$ Right=�6>   5.         EditingElementStyle 50      �� 51      " ��6    .�52      ��  �@��TextAlignment$ Right=�6>   �� 53       � �� " DataGridEditableCellBackground# [ 6;   54      56        57      $	 TH chỉ tiêu��6%   $	
 100 59   %    58   %   �� *ThucHien_chitieu+ 5:      �� 5;      " ��6    .�5<      ��  �@��TextAlignment$ Right=�6>   5=       5?      �� 5@      " ��6    .�5A      ��  �@��TextAlignment$ Right=�6>   �� 5B       � ��# [ 6;   5C      5E        5F      $	 Tỷ lệ CT��6%   $
 80 5H   %   $
 True��5I   %    5G   %   �� *TyLe_chitieu+ 5J      �� 5K      " ��6    .�5L      ��  �@��TextAlignment$ Right=�6>   5M      5O        5R      $	 KH công suất��6%   $	
 100 5T   %    5S   %   �� *KeHoach_CongSuat+ 5U      �� 5V      " ��6    .�5W      ��  �@��TextAlignment$ Right=�6>   5X       5Z      �� 5[      " ��6    .�5\      ��  �@��TextAlignment$ Right=�6>   �� 5]       � ��# [ 6;   5^      5`        5a      $	 TH công suất��6%   $	
 100 5c   %    5b   %   �� *ThucHien_CongSuat+ 5d      �� 5e      " ��6    .�5f      ��  �@��TextAlignment$ Right=�6>   5g       5i      �� 5j      " ��6    .�5k      ��  �@��TextAlignment$ Right=�6>   �� 5l       � ��# [ 6;   5m      5o        5p      $	 Tỷ lệ CS��6%   $
 80 5r   %   $
 True��5s   %    5q   %   �� *TyLe_CongSuat+ 5t      �� 5u      " ��6    .�5v      ��  �@��TextAlignment$ Right=�6>   5w      5y        5|      $	 KH bệnh án��6%   $	
 100 5~   %    5}   %   �� *KeHoach_BenhAn+ 5      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Right=�6>   5�       5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Right=�6>   �� 5�       � ��# [ 6;   5�      5�        5�      $	 TH bệnh án��6%   $	
 100 5�   %    5�   %   �� *ThucHien_BenhAn+ 5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Right=�6>   5�       5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Right=�6>   �� 5�       � ��# [ 6;   5�      5�        5�      $	 Tỷ lệ BA��6%   $
 80 5�   %   $
 True��5�   %    5�   %   �� *TyLe_BenhAn+ 5�      �� 5�      " ��6    .�5�      ��  �@��TextAlignment$ Right=�6>   5�      5�      5�      5�      5�      