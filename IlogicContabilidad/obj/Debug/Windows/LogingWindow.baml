   M S B A M L   `   `   `  ����M  IIlogicContabilidad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IlogicContabilidad.WindowsIlogicContabilidad.Windows  5   	   M+clr-namespace:IlogicContabilidad.ViewModelsIlogicContabilidad.ViewModels  5   	   -    'IlogicContabilidad.Windows.LogingWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:IlogicContabilidad.Windows     5   	   :dc+clr-namespace:IlogicContabilidad.ViewModels     5   	     � Title$  Ingresar��5	   	   $��554.643��6   $��365.994��6+    � DataContext 5
      3  -IlogicContabilidad.ViewModels.LogingViewModel  5   
   .��5      � -   5         �Name$ grid1��5       � ColumnDefinitions 5   
   �� 5      $	��99* �6   �� 5      $
��160* �6   �� 5      $	��94* �6    � RowDefinitions 5   
   �� 5      $	��92* �6   �� 5      $	��96* �6   �� 5      $	��10* �6   �� 5      $	��52* �6   �� 5      $	��53* �6   �� 5      $
��131* �6   �� 5      $	��60* �6   .+�5   
   �� -   5         ��Name$ comboBox��5      $��1��6%    �� DisplayMemberPath$ descripcion��62   $��1��6�   $��26��6�   $��Bottom=�6�   ��6R   �� *Users+ �� SelectedItem 6p   �� *Selecteduser+ �� SelectedValuePath 6�   �� *UsuarioActual.keyCi+6�   �� 5   
   -   5        	 ��Name$	 label��5      $��Seleccione Usuario��6   $��0,0,0,26q�6<   $��1��6N   $��Center=�6[   $��1��6   $��25��6�   $��Bottom=�6�   G� 5   
   -   5        
 G�Name$
 passwordBox��5      $��3��6+   $��1��68   $��27��6H   $��Bottom=�6T   �� 5   
   -   5        $	 
label_Copy��5      $��Ingrese Clave��6$   $��0,0,0,27q�6<   $��3��6N   $��Center=�6[   $��1��6   �� 5    
   -   5         ��Name$ button��5       $��Ingresar��6!   $��85,0,0,0q�64   $��4��6F   $��1��6S    �� 	IsDefault . $��31��6t   $	��Top=�6�   ��6�   �� *LogingCommand+��6�   ��  �� ElementName$ passwordBox�� �� Mode$ OneWay=��� 5!   
   -   5        $	 label1��5!      $��Contabilidad��6    $	��Top=�67   $��32��6O   $��Microsoft Sans Serif)�6[   $��18(�6}   $
��Bold"�6�   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�   
�������$��1��6�   $��Center=�6�   $��Italic$�6  $��1��6  $��0,12,0,0q�6,  �� 5"   
   -   5         ��Name$ 	textBlock��5"      $��6��6'   $
��Wrap=�64   $��10(�6H   $��ExtraCondensed&�6V    �� TextAlignment$ Center=�6s   
����������	#FF424242$��3��6�   �� 6�   $>�8Este Sistema esta protegido por las Leyes Venezolanas e ��6�   �� 6  $�I��6  �� 6  $�nternacionesles��6"  �� 6;  $�.��6?  �� 6J  �� 6V  $�Ilogic Softwares��6Z  �� 6t  $��Arial)�6x  $�©��6�  �� 6�  $��Arial)�6�  $� 2016��6�  �� 6�  �� 6�  �� 6�  �� 6�  6�  �� 5#   
   -	   5         ��Name$ image��5#      $��68��6   $��
43,21,44,0q�6+   $	��Top=�6?   $2��,/IlogicContabilidad;component/ILOGICICON.png��6W   $��1��6�   �� 5$   
   -
   5        $	 Mensaje��5$      $��1��6?   $��0,31,0,0q�6O   $��4��6a    J� RenderTransformOrigin$ 0.895,0.038&�6n   $��Right=�6�   
���  ����6!   �� *	Validator+6�   �� 5%   
   -   5        $	 label1_Copy��5%      $��Ilogic Softwares��6%   $��
64,79,57,0q�6@   $	��Top=�6T   $��42��6l   $��Microsoft Sans Serif)�6x   $��29.333(�6�   $
��Bold"�6�   $ Display=�6�   
�������$��3��6�   $��2��6  $��Center=�6  5'      5(      