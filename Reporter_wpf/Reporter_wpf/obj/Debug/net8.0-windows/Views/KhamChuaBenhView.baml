   M S B A M L   `   `   `  ����G  CReporter_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Reporter_wpf.ViewModelsReporter_wpf.ViewModels  5      )    #Reporter_wpf.Views.KhamChuaBenhView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      <
viewmodels%clr-namespace:Reporter_wpf.ViewModels     5        � DataContext  5      3   -Reporter_wpf.ViewModels.KhamChuaBenhViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $&�� Khám chữa bệnh toàn viện��6      
TitleStyle#��[  5      $��0��5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ KhamChuaBenhDataGrid��5      $��1��5        ModernDataGrid#��[ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5        DataGridCellStyle   	CellStyle# [ 5        DataGridRowStyle   RowStyle# [ 5         AutoGenerateColumns$ False��5         
IsReadOnly$ False��5      ��5      �� *KhamChuaBenhData+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 STT��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 5    %      
IsReadOnly$
 True��5!   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *STT+5!   %     5"      $	 Hoạt động��6%   $
 * 5$   %   $
 True��5%   %    5#   %   �� *
HoatDong+5%   %     5&      $	 
Đơn vị��6%   $	
 100 5(   %   $
 True��5)   %    5'   %   �� *DonVi+5)   %     5*      $	 Kế hoạch��6%   $	
 120 5,   %    5+   %   �� *	KeHoach+   ElementStyle 5-      �� 5.       �� 
TargetType" ��6    .�5/      ��  �� Property �@��TextAlignment �� Value$ Right=�6>   50         EditingElementStyle 52      �� 53      " ��6    .�54      ��  �@��TextAlignment$ Right=�6>   �� 55       � �� " DataGridEditableCellBackground# [ 6;   56      58        59      $	 Thực hiện��6%   $	
 120 5;   %    5:   %   �� *
ThucHien+ 5<      �� 5=      " ��6    .�5>      ��  �@��TextAlignment$ Right=�6>   5?       5A      �� 5B      " ��6    .�5C      ��  �@��TextAlignment$ Right=�6>   �� 5D       � ��# [ 6;   5E      5G        5H      $	 Tỷ lệ (%)��6%   $	
 100 5J   %   $
 True��5K   %    5I   %   �� *TyLeThucHien+ 5L      �� 5M      " ��6    .�5N      ��  �@��TextAlignment$ Right=�6>   5O      5Q      5S      5T      5U      