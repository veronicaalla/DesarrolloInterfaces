   M S B A M L   `   `   `  ����I  EUT5E4_Veronica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UT5E4_VeronicaUT5E4_Veronica  5   	   "    UT5E4_Veronica.ReservaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:UT5E4_Veronica     5   	   -   5          � Title$  Reserva��5   	   $	��260��6   $	��700��6&    � 
ResizeMode$ NoResize=�5	   	    � 	Resources 5         TamañoButtons �� 
TargetType �� Property �� Value  LabelDerecha  AlturaTextBox��%  &	        &	 n     &	 �     �� 5   
   " ��6&   .�5      ��  � ��$	 100��6&   �� 5       � ��$	 0,5q�6'   5      �� 5   
   " ��6%   .�5      ��  � ��$ Right=�64   5      �� 5   
   " ��6&   .�5      ��  � ��$ 20��6'   5      5      .��5      ��  �� Orientation$ Vertical=�6   $	��5,5q�6(   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      $��* �6#   �� 5       $
��0.5* �6#   �� 5!      $��* �6#    � RowDefinitions 5#      �� 5$      $��* �6    �� 5%      $��* �6    �� 5&      $��* �6    .+�5*      �� $��Nombre��6   $��0��6%   $��0��65   #��[ 6B   �� 5+      -   5        	 ��Name$	 	txtNombre��5+      $��1��6)   $��0��69   $��3��6F   #��[ 6Z   �� 5-      $��Fecha��6   $��0��6$   $��1��64   #��[ 6A   (  "System.Windows.Controls.DatePicker  5.      -   5        
  Name$
 dpFecha��5.         SelectedDateFormat$ Short=�6*   $��1��6H   $��1��6X   �� 50      $��Telefono��6   $��2��6'   $��1��67   #��[ 6D   �� 51      -   5        $	 txtTelefono��51      $��3��6+   $��1��6;   #��[ 6H    �� 	MaxLength$ 9��6�   �� 53      $��
Comensales��6   $��0��6)   $��2��69   #��[ 6F   �� 54      -   5        $	 txtComensales��54      $��1��6-   $��3��6=   #��[ 6J   6q   �� 56      $��Asiste��6   $��2��6%   $��2��65   #��[ 6B   �� 57      -   5         ��Name$ 	chkAsiste��57      $��3��6*   $��2��6:   $��0,7,0,0q�6G   58      �� 5:   
   $��Observaciones: ��6   �� 5;   
   -   5        $	 txtObservaciones��5;      $��80��6-   $	��674��69    �� AcceptsReturn .  �� TextWrapping$
 Wrap=�6Z   $
��Left=�6n   �� 5<   
   -   5        $	 txtDni��5<      $��10q�6#   6/   � 5>   
   $��Right=�6   .+�5?      �� -	   5         ��Name$ 
btnAceptar��5?      $��Aceptar��6-   #��[  6B    �� 	IsDefault . $	��5,5q�6�   �� 5@      -
   5        $ btnCancelar��5@      $��Cancelar��6-   #��[  6B    �� IsCancel . 6�   5A      5B      5C      