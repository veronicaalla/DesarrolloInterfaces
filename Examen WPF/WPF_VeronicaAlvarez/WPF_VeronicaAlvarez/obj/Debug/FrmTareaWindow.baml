   M S B A M L   `   `   `  ����N  JWPF_VeronicaAlvarez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WPF_VeronicaAlvarezWPF_VeronicaAlvarez  5   	   (    "WPF_VeronicaAlvarez.FrmTareaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WPF_VeronicaAlvarez     5   	     � Title$  Tarea��5   	   $	��450��6   $	��700��6$    � 
ResizeMode$ NoResize=�60   .��5	      � .+�5
   
   �� $��Desarrollador ��6   $��Right=�6)   $��Bottom=�6E   $��0,0,466,383q�6`    J� RenderTransformOrigin$ -2.019,-5.457&�6u   �� 5   
   -   5         ��Name$ txtCodigoDesarrollador��5      $��Right=�62   $��Bottom=�6N   $��0,0,583,387q�6i   $��91��6~   �� 5   
   -   5        $ txtNombreDesarrollador��5      $��Right=�62   $��Bottom=�6N   $��0,0,139,387q�6i   $	��282��6~    �� 
IsReadOnly . 6�   � 5   
   $	��Top=�6   $��
30,62,50,0q�6(    � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      $��* �6#   �� 5      $
��0.5* �6#   �� 5      $��* �6#    � RowDefinitions 5      �� 5      $��* �6    $��30��6+   �� 5      $��* �6    $��30��6+   .+�5      �� $��	Proyecto:��6   $��0��6(   $��0��68   $��Right=�6E   �� 5      -   5        $ txtProyecto��5      $��1��6+   $��0��6;   $��15��6H   �� 5       $��	Estimado:��6   $��2��6(   $��0��68   $��Right=�6E   �� 5!      -   5        $ txtEstimado��5!      $��3��6+   $��0��6;   $��15��6H   6T   �� 5#      $��Prioriedad:��6   $��0��6*   $��1��6:   $��Right=�6G   �� 5$      -   5         ��Name$ cmbPrioriedad��5$      $��1��6.   $��1��6>   $��20��6L   .@�5%      �� $
��Baja��6   �� 5&      $��Media��6    �� 
IsSelected . 6/   �� 5'      $
��Alta��6   �� 5(      $��Critica��6   5)      �� 5+      $��	Cerrada: ��6   $��2��6)   $��1��69   $��Right=�6F   �� 5,      -   5        $��
ckbCerrada��5,      $��3��6*   $��1��6:   $��5q�6G   5-      �� 50   
   	 �� Orientation$	 Vertical=�6   $��26,128,26,89q�6,   $ 0.338,0.697&�6B   .+�51      �� $��Descripcion: ��6   $ 0.473,7.436&�6,   �� 52      -   5        $ txtObservaciones��52      $	��636��60   $	��129��6<   $ 0.191,1.082&�6I   �� 54      $	 
Horizontal=�6   $��Right=�62   $	��5,5q�6N   .+�55      �� -   5        
 ��Name$
 
btnAceptar��55      $��Aceptar��6-   $��Right=�6X   $��65��6t   $��0,0,5,0q�6   �� 56      -	   5        $
 btnCancelar��56      $��Cancelar��6.   $��Right=�6[   $��65��6x   $��5,0,0,0q�6�   57      58      59      5:      