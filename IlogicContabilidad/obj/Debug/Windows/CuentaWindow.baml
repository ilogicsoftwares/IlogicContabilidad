   M S B A M L   `   `   `  ����M  IIlogicContabilidad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:IlogicContabilidad.WindowsIlogicContabilidad.Windows  5   	   M+clr-namespace:IlogicContabilidad.ViewModelsIlogicContabilidad.ViewModels  5   	   -    'IlogicContabilidad.Windows.CuentaWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:IlogicContabilidad.Windows     5   	   :vm+clr-namespace:IlogicContabilidad.ViewModels     5   	   X TXceed.Wpf.Toolkit, Version=3.0.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	     � Title$  Plan de Cuentas��5
   	   $	��306��6!   $��666.1��6.    � 	Resources 5      ;  5IlogicContabilidad.ViewModels.RadioBoolToIntConverter   radioBoolToIntConverter�� 5   
   %   &	          5      6)   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��82* �6   �� 5      $
��354* �6   �� 5      $��8* �6   �� 5      $	��75* �6   �� 5      $
��130* �6   �� 5      $��9* �6   .+�5   
   �� $��5��6   ���	#FFF4F4F5$��33��69   $��
10,113,1,0q�6E   
���   �$	��Top=�6h   �� 5   
   -   5         ��Name$ label��5      $��Código:��6   $��0,20,0,0q�61   $	��Top=�6C   $��Right=�6[   $��26��6~   %  Xceed.Wpf.Toolkit.MaskedTextBox  5   
   -   5          Name$ codigo��5         Mask$ 0.0.0.00.000��6-   $��1��6B   $��26��6R   $��0,20,0,0q�6^    �� TextWrapping$
 Wrap=�6p   $	��Top=�6�   ��6�   �� *codigo+ �� BindsDirectlyToSource . 6�   �� 5   
   -   5        $ 
label_Copy��5      $��Descripción:��6$   $��0,51,0,0q�6;   $	��Top=�6M   $��Right=�6e   $��26��6�   �� 5   
   -   5         ��Name$ descripcion��5      $��1��6'   $��26��67   $��0,51,0,0q�6C   $
 Wrap=�6U   $	��Top=�6�   $��4��6�   ��6i   �� *descripcion+6�   �� 5    
   -   5        $ label_Copy1��5       $��Opciones��6%   $��	10,82,1,0q�68   $	��Top=�6K   $��Center=�6c   $��26��6�   $
��Bold"�6�   $��5��6�   ���	#FF00C0FF6�   	� 5!   
   -   5        	 	�Name$	 radioButton��5!      $��Cta. de Balance��6+   $��1��6E   $
��Left=�6U   $��
10,119,0,0q�6p   $	��Top=�6�   
 d� 	IsChecked
 6�   �� *tipo+ �� ConverterParameter$ 1�� �� 	Converter# [   �� UpdateSourceTrigger$ Default=�	� 5"   
   -   5        $	 radioButton_Copy��5"      $��Cta. de Edo. Resultado��60   $��1��6Q   $
��Left=�6a   $��150,119,0,0q�6|   $	��Top=�6�   
 6�   �� *tipo+$ 2��# [  $ Default=��� 5#   
   -   5        $ label_Copy2��5#      $��Resumen��6%   $��
10,151,1,0q�67   $	��Top=�6K   $��Center=�6c   $��26��6�   $
��Bold"�6�   $��5��6�   ���	#FF00C0FF6�   �� 5$   
   
���   �$��1q�6%   $��5��69   $��89��6M   $��
10,180,1,0q�6Y   $	��Top=�6m   �� 5%   
   -	   5        $ label_Copy3��5%      $��Saldo Anterior��6%   $��33,182,235,0q�6>   $	��Top=�6T   $��Right=�6l   $��26��6�   $��1��6�   $��Center=�6�   �� 5&   
   -
   5        $ label_Copy5��5&      $
��Debe��6%   $��187,182,129,0q�64   $	��Top=�6K   $��Right=�6c   $��26��6�   $��1��6�   $��Center=�6�   �� 5'   
   -   5        $ label_Copy6��5'      $��Haber��6%   $��305,182,7,0q�65   $	��Top=�6J   $��Right=�6b   $��26��6�   $��1��6�   $��Center=�6�   �� 5(   
   -   5        $ label_Copy7��5(      $��Saldo��6%   $��39,182,47,0q�65   $	��Top=�6J   $��Right=�6b   $��26��6�   $��4��6�   $��Center=�6�   $��44��6�   �� 5)   
   -   5        $ codigo_Copy1��5)      $��1��6(   $��26��68   $��17,237,223,0q�6D   $
 Wrap=�6Z   $	��Top=�6�    �� 
IsReadOnly . ��6n   �� *	acumini+ . 6�   �� 5*   
   -   5        $ codigo_Copy��5*      $��1��6'   $��26��67   $��150,237,90,0q�6C   $
 Wrap=�6Y   $	��Top=�6�    . ��6m   �� *
acumdebe+ . 6�   �� 5+   
   -   5        $ codigo_Copy2��5+      $��1��6(   $��26��68   $��269,237,54,0q�6D   $
 Wrap=�6Z   $	��Top=�6�   $��3��6�    . ��6n   �� *	acumhaber+ . 6�   �� 5,   
   -   5        $ codigo_Copy3��5,      $��4��6(   $��26��68   $��
0,237,10,0q�6D   $
 Wrap=�6X   $	��Top=�6�    . ��6l   �� *	acumsaldo+ . 6�   �� 5-   
   -   5        $ codigo_Copy5��5-      $��1��6(   $��26��68   $��150,208,90,0q�6D   $
 Wrap=�6Z   $	��Top=�6�    . ��6n   �� *	debeini+ . 6�   �� 5.   
   -   5        $ codigo_Copy6��5.      $��1��6(   $��26��68   $��269,208,54,0q�6D   $
 Wrap=�6Z   $	��Top=�6�   $��3��6�    . ��6n   �� *
haberini+ . 6�   �� 5/   
   -   5        $ codigo_Copy7��5/      $��4��6(   $��26��68   $��
0,208,10,0q�6D   $
 Wrap=�6X   $	��Top=�6�    . ��6l   �� *
saldoini+ . 6�   �� 50   
   -   5        $ label_Copy8��50      $��Monto Inicial��6%   $��10,208,344,0q�6=   $	��Top=�6S   $��Right=�6k   $��26��6�   $��2��6�   �� 51   
   -   5        $ label_Copy4��51      $��Saldos��6%   $��10,234,344,0q�66   $	��Top=�6L   $��Right=�6d   $��26��6�   $��2��6�   53      54      