   M S B A M L   `   `   `  ����G  CReporter_wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Reporter_wpf.ViewModelsReporter_wpf.ViewModels  5      )    #Reporter_wpf.Views.DichVuYeuCauView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      <
viewmodels%clr-namespace:Reporter_wpf.ViewModels     5        � DataContext  5      3   -Reporter_wpf.ViewModels.DichVuYeuCauViewModel  5   
   .��5      � $��20q�6    � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $;��5Kết quả thực hiện dịch vụ theo yêu cầu��6      
TitleStyle#��[  5      $��0��5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DichVuYeuCauDataGrid��5      $��1��5        ModernDataGrid#��[ 5        DataGridColumnHeaderStyle   ColumnHeaderStyle# [ 5        DataGridCellStyle   	CellStyle# [ 5        DataGridRowStyle   RowStyle# [ 5         AutoGenerateColumns$ False��5         
IsReadOnly$ False��5      ��5      �� *DichVuYeuCauData+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$		 STT��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 50 5    %      
IsReadOnly$
 True��5!   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   %   �� *STT+5!   %     5"      $	 	Tên khoa��6%   $
 * 5$   %   $
 True��5%   %    5#   %   �� *	TenKhoa+5%   %     5&      $	 Tổng��6%   $	
 100 5(   %   $
 True��5)   %    5'   %   �� *Tong+   ElementStyle 5*      �� 5+       �� 
TargetType" ��6    .�5,      ��  �� Property �@��TextAlignment �� Value$ Right=�6>   5-      5/        50      $	 
Chọn PTV��6%   $	
 100 52   %    51   %   �� *	ChonPTV+ 53      �� 54      " ��6    .�55      ��  �@��TextAlignment$ Right=�6>   56         EditingElementStyle 58      �� 59      " ��6    .�5:      ��  �@��TextAlignment$ Right=�6>   �� 5;       � �� " DataGridEditableCellBackground# [ 6;   5<      5>        5?      $	 
Mổ sớm��6%   $	
 100 5A   %    5@   %   �� *MoSom+ 5B      �� 5C      " ��6    .�5D      ��  �@��TextAlignment$ Right=�6>   5E       5G      �� 5H      " ��6    .�5I      ��  �@��TextAlignment$ Right=�6>   �� 5J       � ��# [ 6;   5K      5M        5N      $	 Gói PT��6%   $	
 100 5P   %    5O   %   �� *GoiPT+ 5Q      �� 5R      " ��6    .�5S      ��  �@��TextAlignment$ Right=�6>   5T       5V      �� 5W      " ��6    .�5X      ��  �@��TextAlignment$ Right=�6>   �� 5Y       � ��# [ 6;   5Z      5\      5^      5_      5`      