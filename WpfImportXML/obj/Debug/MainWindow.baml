   M S B A M L   `   `   `  ����G  CWpfImportXML, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfImportXMLWpfImportXML  5   	       WpfImportXML.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfImportXML     5   	     � Title$  WpfImportXML��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   o� $��25��6   $	��Top=�6   .@�5      m� $
��File��6   .@�5      m� -   5         m�Name$ MenuAdd��5      $��
Import XML��6,   6Y   m� 5      -   5        $
��Edit��5      6C   m� 5      -   5        $��Delete��5      6G   �� 5      m� 5      -   5        $
��Exit��5      6D   5      5      ]� 5   
   ��. $��0,25,0,0q�6)   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�62   $��5,5,5,0q�6G   .+�5      �� -   5         ��Name$ btn_Add��5      $��87��6@   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��button_pics\add.png��6    $��15��6=   $��15��6H   �� 5      $��
Import XML��6$   $��Center=�66   $��5,0,0,0q�6Q   5      5      �� 5      -   5        $ btn_Edit��5      $��5,0,0,0q�6+   $��87��6<   .��5      �� $ 
Horizontal=�6!   .+�5      �� $��button_pics\edit.png��6    $��15��6>   $��15��6I   �� 5      $
��Edit��6$   $��Center=�60   $��5,0,0,0q�6K   5      5       �� 5!      -   5        $ btn_Del��5!      $��5,0,0,0q�6*   $��87��6;   .��5"      �� $ 
Horizontal=�6!   .+�5#      �� $��button_pics\del.png��6    $��15��6=   $��15��6H   �� 5$      $��Delete��6$   $��Center=�62   $��5,0,0,0q�6M   5%      5&      5'      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ DataGridXML��5(      $��5q�6,   ��67   �� 6Q   5)      5*      5+      