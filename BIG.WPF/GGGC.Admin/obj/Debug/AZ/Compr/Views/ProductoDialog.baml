   M S B A M L   `   `   `  ����E  AGGGC.Admin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:GGGC.Admin.AZ.Compr.ViewsGGGC.Admin.AZ.Compr.Views  5   	   p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5	   	   .    (GGGC.Admin.AZ.Compr.Views.ProductoDialog   5   	   n jTelerik.Windows.Controls.Charting, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7n jTelerik.Windows.Controls.GridView, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Controls.Chart, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7q mTelerik.Windows.Controls.Spreadsheet, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7j fTelerik.Windows.Controls.Data, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Documents.Core, Version=2017.2.428.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k	 gTelerik.Windows.Controls.Input, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m
 iTelerik.Windows.Controls.Docking, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p lTelerik.Windows.Controls.Navigation, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7t pTelerik.Windows.Controls.DataServices50, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7z vTelerik.Windows.Controls.FixedDocumentViewers, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7| xTelerik.Windows.Controls.FixedDocumentViewersUI, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7k gTelerik.Windows.Cloud.Controls, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f bTelerik.Windows.Documents, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7w sTelerik.Windows.Controls.DataVisualization, Version=2017.2.503.40, Culture=neutral, PublicKeyToken=5803cfa389c90ce7_telerik1http://schemas.telerik.com/2008/xaml/presentation        	 
         R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   a ]Syncfusion.Shared.Wpf, Version=15.2451.0.40, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Tools.Wpf, Version=15.2451.0.40, Culture=neutral, PublicKeyToken=3d67ed1f87d44c892Controls!http://schemas.syncfusion.com/wpf   5   
   <d2http://schemas.microsoft.com/expression/blend/2008   5   	   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5   	   5local'clr-namespace:GGGC.Admin.AZ.Compr.Views   5   	   dtoolkitTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit   5	   	     � Title$  ProductoDialog��5   	   $	��450��6!   $	��619��6.    � AllowsTransparency .  � WindowStyle$
 None=�6T    � WindowStartupLocation$ CenterScreen=�6g    � 	Resources 5         AutoCompleteStyle �� 
TargetType �� Property �� Value  ArticulosSearchComplete �� Orientation2   ,GGGC.Admin.AZ.Compr.Views.ArticulosViewModel  	ViewModel��%i  &	        &	 �     7   7   7   7   7   &	 $    �� 5   
   " ��5      .�5      ��  � ��$ Segoe UI)�5      �� 5       � ��$ 13.333(�5      �� 5       � �� �	#FF0A0A0A5      �� 5       � ��$ Center=�5      5      �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� 8��  ��6   �� *Codigo+64   �� 5      $�� ��6   8�� 6%   �� 5      8�� ��6   �� *Descripcion+69   �� 5      $�� ��6   8�� 6%   �� 5      8�� $y�Hidden=�6g   ��6   �� *Nombrecompleto+6g   5       5"        5#   
   6#   5$      .��5&      � 	 � DataContext#	 [ 6   ���#F7F7F7$��0,0,0,0q�6I   
 � RowDefinitions
 5'   
   �� 5(      $��* �6   �� 5)      $��* �6   �� 5*      $��* �6   �� 5+      $��* �6   �� 5,      $��* �6   �� 5-      $��* �6   �� 5.      $��* �6   �� 5/      $��* �6   �� 50      $��* �6   �� 51      $��* �6   �� 52      $��* �6   �� 53      $��* �6   �� 54      $��* �6   �� 55      $��* �6   .+�58   
   � $��1��6    � ColumnDefinitions 59      �� 5:      $��20 �6#   �� 5;      $��* �6#   �� 5<      $��* �6#   .+�5>      �� -   5        $��lblTitle��5>      $��1��6%   ���#0F0F0F$��	Articulos��6J   $��SemiBold"�6^   $��22(�6u   $��0,-9,0,0q�6�   5@      �� 5A   
   $��2��6   	 �� X1$ 0��6   	 �� X2$	 380��6#   	 �� Y1$ 0��6,   	 �� Y2$ 0��64   ���#AFAFAF$��1��6L   $��20,0,0,0q�6`   � 5B   
   $��3��6    5C      �� 5D      $
��164* �6#   �� 5E      $
��146* �6#   �� 5F      $	��68* �6#   �� 5G      $	��29* �6#   �� 5H      $
��213* �6#   .+�5J      � $��10,-21,-10,21q�6   $��5��6*    5K      �� 5L      $��8 �6'   �� 5M      $
��312* �6'   �� 5N      $
��239* �6'   �� 5O      $	��60* �6'   .+�5Q      �� $��Articulo��6   ���#666666$��17(�6@   $��Center=�6N   $��
-8,1,246,1q�6i   $��30��6}   $��2��6�   �� 5R      -   5        $
��item��5R   5   $��15(�6   $��0��6(   ���#C1C1C1$��1��6W   $��30��6g   $��Center=�6s   $��
51,0,155,2q�6�   6�   �� 5S      $��Cantidad��6   ���#666666$��17(�6@   $��2��6N   $��Center=�6^   $��
121,1,41,1q�6y   $��30��6�   1 	 +Telerik.Windows.Controls.RadAutoCompleteBox  5T      -   5          Name$ articulosAutoCompleteBox��5X      $y�Hidden=�5U         TextSearchMode$ Contains=�5V         WatermarkContent$ 	Ya cambie��5W         AutoCompleteMode$ Suggest=�5Y         TextSearchPath$ Nombrecompleto��5Z         SelectionMode$ Single=�5[         DropDownItemTemplate# [ 5]         ItemsSource 5\      �� *ArticulosList+5]      �� 5^      $��Descripcion��6   ���#666666$��17(�6C   $��Center=�6Q   $��
157,1,59,1q�6l   $��30��6�   $��1��6�   �� 5_      -   5         ��Name$ 	item_Copy��5_   5   $��15(�6   $��0��6(   ���#C1C1C1$��1��6^   $��30��6n   $��Center=�6z   $��251,0,118,2q�6�   $��2��6�   5a      / 	 )Telerik.Windows.Controls.RadNumericUpDown  5b      -   5          Name$ Cantidad��5b   =      ValueFormat$ Numeric=�6'      NumberDecimalDigits$ 0��6�   $��4��6�   $
��Left=�6�   $��118,-21,0,0q�6�   $	��Top=�6�   $��32��6  $��15(�6  $��80��6'  +  %Telerik.Windows.Controls.RadRangeBase   Value 6t   �� *
Cantidad+ �� Mode$ TwoWay=�5d      5f      � 5h   
   $��4��6   $��0,16,0,6q�6   $��4��6.    5i      �� 5j      $
��346* �6#   �� 5k      $
��273* �6#   .+�5n      &   System.Windows.Controls.DataGrid  -   5        $��	dataGrid1��5p         AutoGenerateColumns .    
IsReadOnly . $	��Top=�5q      $	��166��6+   $��
0,27,0,-87q�68   $��2��6L   5s      �� 5t      $	��IVA��6   ���#666666$��17(�67   $��Center=�6E   $��212,-16,53,92q�6`   $��30��6w   �� 5u      $��Total��6   ���#666666$��17(�69   $��Center=�6G   $��41,-16,151,92q�6b   $��30��6y   $��1��6�   5v      � 5w   
   $��7��6   $��0,6,0,26q�6   $��3��6.   .+�5x      �  5y      �� 5z      $��20 �6'   �� 5{      $��* �6'   �� 5|      $
��Auto �6'   5      5�      � 5�   
   $��8��6   $��	0,19,0,20q�6   $��3��6/    5�      �� 5�      $
��207* �6#   �� 5�      $
��201* �6#   .+�5�      � $��2��6    5�      �� 5�      $��20 �6'   �� 5�      $��* �6'   �� 5�      $	��194 �6'   5�      5�      � 5�   
   $��8��6   $��0,0,0,15q�6   $��2��6.    5�      �� 5�      $
��167* �6#   �� 5�      $
��263* �6#   5�      � 5�   
   $��12��6   .+�5�      � $��	0,0,0,-11q�6    5�      �� 5�      $	��31* �6'   �� 5�      $
��377* �6'   .+�5�      �� -   5        $��
Actualizar��5�        ExportButtonStyle#��[ 6.   $��17(�6Y   $��1��6�   $��112,-1,361,1q�6�   �� 5�      -   5        $��1��5�      #��[ 6)   $��17(�6U   $��Cancelar��6s   $��247,-1,201,1q�6�   5�      5�      �� 5�   
   $��Precio��6   ���#666666$��17(�66   $��Center=�6D   $��
20,0,518,2q�6_   $��30��6s   $��4��6   -  'Syncfusion.Windows.Shared.DoubleTextBox  5�   
   -	   5        $
��rate��5�   m   $��15(�6!     �� 
IsReadOnly  . ! �� TextAlignment$! Right=�6A   ���#C1C1C1$��30��6y   $��
89,2,420,0q�6�   $��4��6�   .��6�   5�      )   #GGGC.Admin.AZ.Compr.Views.AddCompra  5�   
   $
��Left=�6   $	��100��65   $��
222,10,0,0q�6B   $��4��6V   $	��Top=�6g   $	��100��6     5�   
   -
   5        "  Name$" rate_Iva��5�   �   $��15(�6!     . $! Right=�6A   #   NumberDecimalDigits$# 0��6W   ���#C1C1C1$��30��6�   $��258,2,251,0q�6�   $��4��6�   �� 5�   
   -   5        $ ��Name$$ Total��5�   +   $��15(�6   $��0��6   ���#C1C1C1$��28��6Q   $��Center=�6]   $��
471,2,55,2q�6x   $��4��6�   5�      5�      