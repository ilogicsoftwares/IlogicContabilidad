   M S B A M L   `   `   `  ����M  IIlogicContabilidad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IlogicContabilidad.WindowsIlogicContabilidad.Windows  5   	   0    *IlogicContabilidad.Windows.PrincipalWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:IlogicContabilidad.Windows     5   	     � Title$%  Ilogic Softwares - Contabilidad��5   	   $��367.081��61   $��564.596��6B   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��64* �6   �� 5      $
��273* �6   .+�5   
   o� -   5         o�Name$
 menu��5      $��31��6   $	��Top=�6)   .@�5      m� $��Archivo��6   .@�5      m� $��Nuevo��6   .@�5      m� -   5        $��CuentaWindow��5   J   $��Plan de Cuentas��6   6J   m� 5      -   5        $��ComprobWindow��5   O   $��Tipos de Comprobante��6   6O   5      m� 5      $��
Configurar��6   5      �� 5      m� 5      -   5        $��Salir��5      6*   5      m� 5      $��Proceso��6   .@�5      m� -   5        $��NewCompronWindow��5   9   $��Generar Comprobantes��6   6Q   5      5      � 5   
   $��34��6   $	��Top=�6   $��0,30,0,0q�63   .+�5       �� -   5         ��Name$ CommandGuardar��5       $
��Left=�6.   $��35��6I   $��28,0,0,0q�6T      MetroCircleButtonStyle#���   6�    � ToolTip$ Guardar(Ctrl+G)��6�   ��6f   �� *GuardarEntidadCommand+.��5!      �� $��15��6   $��15��5"      
����� � J� OpacityMask 5$      !� 5%       j� Stretch$
 Fill=�6&     appbar_save !� Visual# �  5&      5(      5)      �� 5*      -   5        $ CommandNuevo��5*      $
��Left=�6U   $��35��6p   #���   6{   $ Nuevo(Ctrl+N)��6�   ��6,   �� *NuevaEntidadCommand+.��5+      �� $��15��6   $��15��5,      
����� � 5.      !� 5/      $
 Fill=�6&     
appbar_add# �  50      52      53      �� 54      -   5        $ CommandGuardar_Copy��54      $
��Left=�63   $��35��6N   $��56,0,0,0q�6Y   #���   6k   $ Buscar(Ctrl+B)��6�   .��55      �� $��15��6   $��15��56      
����� � 58      !� 59      $
 Fill=�6&     appbar_magnify# �  5:      5<      5=      �� 5>      -	   5        $ CommandNuevo_Copy��5>      $
��Left=�6]   $��35��6x   #���   6�   $ Eliminar(Ctrl+N)��6�   $��84,0,0,0q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ��61   �� *EliminarEntidadCommand+z�5?      V� 5@      .~�5A      �� �� 5B      �� 5C      	 �� Angle$	 45.566Q�6*   T� 5D      5E      .��5G      �� $��15��6   $��15��5H      
���  �� 5J      !� 5K      $
 Fill=�6&   # �  5L      5N      5O      5Q      5S      5T      