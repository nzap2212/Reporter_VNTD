   M S B A M L   `   `   `  ����G  CReporter_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Reporter_wpf.ViewModelsReporter_wpf.ViewModels  5      ,    &Reporter_wpf.Views.PhongKhamCapCuuView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      <
viewmodels%clr-namespace:Reporter_wpf.ViewModels     5        � DataContext  5      6   0Reporter_wpf.ViewModels.PhongKhamCapCuuViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $*��$Số liệu phòng khám cấp cứu��6      
TitleStyle#��[  5      $��0��5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PhongKhamCapCuuDataGrid��5      $��1��5        ModernDataGrid#��[ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5        DataGridCellStyle   	CellStyle# [ 5        DataGridRowStyle   RowStyle# [ 5         AutoGenerateColumns$ False��5         
IsReadOnly$ False��5      ��5      �� *PhongKhamCapCuuData+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Phòng khám��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 5    %      
IsReadOnly$
 True��5!   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *	PhongKham+5!   %     5"      $	 Tổng số đến khám��6%   $	
 150 5$   %    5#   %   �� *TongSoDenKham+   ElementStyle 5%      �� 5&       �� 
TargetType" ��6    .�5'      ��  �� Property �@��TextAlignment �� Value$ Right=�6>   5(         EditingElementStyle 5*      �� 5+      " ��6    .�5,      ��  �@��TextAlignment$ Right=�6>   �� 5-       � �� " DataGridEditableCellBackground# [ 6;   5.      50        51      $	 Tổng số nhập viện��6%   $	
 150 53   %    52   %   �� *TongSoNhapVien+ 54      �� 55      " ��6    .�56      ��  �@��TextAlignment$ Right=�6>   57       59      �� 5:      " ��6    .�5;      ��  �@��TextAlignment$ Right=�6>   �� 5<       � ��# [ 6;   5=      5?        5@      $	 Tỷ lệ nhập viện��6%   $	
 120 5B   %   $
 True��5C   %    5A   %   �� *TyLeNhapVien+ 5D      �� 5E      " ��6    .�5F      ��  �@��TextAlignment$ Right=�6>   5G      5I      5K      5L      5M      