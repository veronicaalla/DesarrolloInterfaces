   M S B A M L   `   `   `  ����I  EUT5E4_Veronica, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:UT5E4_VeronicaUT5E4_Veronica  5   	       UT5E4_Veronica.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:UT5E4_Veronica     5   	   -   5          � Title$  Gestión de reservas��5   	   $	��450��6&   $	��800��63    � 
ResizeMode$ CanResizeWithGrip=�5	   	    � 	Resources 5         TamañoButtons �� 
TargetType �� Property �� Value  ColumnasLvReservas��%�   &	        &	 I     �� 5   
   " ��6&   .�5      ��  � ��$	 100��6&   5      �� 5   
   " ��6+   .�5      ��  � ��$
 Bold"�6+   �� 5       � ��$ Right=�64   5      5      .��5      ]� ��. $	��5,5q�6%   .+�5   
   � $	��Top=�6   $
��Left=�6)   .+�5      �� -   5         ��Name$ txtFiltrado��5      $	��400��6+   67   �� 5      -   5         ��Name$ 
btnFiltrar��5      $��Filtrar��6)   #��[  6T    �� 	IsDefault . 6{   �� 5      -   5        $ btnNuevaReserva��5      $��Nueva��6.   #��[  6\   $��18,0,0,0q�6�   5      �� 5$   
   $��Bottom=�6   $��-5,-5,-5,-5q�6,   ��5&      �� 5'      .R�5(      � 	 � ColumnDefinitions	 5)      �� 5*      �� 5+      5-      5.      .@�52      �� .��53      �� -   5        
 ��Name$
 tbFiltro��53      $��5q�6.   $��
Sin filtro��69   54      �� 55      $��1��6   $��Right=�6,   .��56      �� -   5        $
 tbRegistros��56      $��5q�61   $��0 registros��6<   57      59      �� 5?   
   -   5        $��
lvReservas��5?      $��Visible=�6%    �� SelectionMode$ Single=�6X    J� 	AllowDrop . $��0,10,0,0q�5A       � ContextMenu 5E      �� 5F      .@�5G      m� -   5         m�Name$ cmsNueva��5G      $��Nueva��61   6@   m� 5H      -	   5        $ cmsVer��5H      $	��Ver��6/   6<   m� 5I      -
   5        $ cmsEliminar��5I      $��Eliminar��64   6F   �� 5J      m� 5K      -   5        $ cmsConfirmar��5K      $��	Confirmar��65    m� IsCheckable . 6[   5L       �� View 5S      �� 5T      .P�5U      ��  �� Width$	 170��6%    �� DisplayMemberBinding 61   �� *Fecha+ �� StringFormat$ 
dd/MM/yyyy����5V      �� 5W      -   5        $��Fecha��5W   3   6D   5Y      �� 5[      -   5        	colNombre��$	 200��5[   8    6E   �� *Nombre+��5\      �� 5]      -   5        $��Nombre��5]   N   5_      �� 5a      $	 150��6%    61   �� *
Comensales+��5b      �� 5c      -   5        $��
Comensales��5c   N   5e      �� 5g      $	 200��6%    61   �� *Asiste+��5h      �� 5i      -   5        $��Asiste��5i   N   5k      5m      5p      5u      5w      