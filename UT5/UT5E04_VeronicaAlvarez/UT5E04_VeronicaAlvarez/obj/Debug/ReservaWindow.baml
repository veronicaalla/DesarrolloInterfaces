   M S B A M L   `   `   `  ����Q  MUT5E04_VeronicaAlvarez, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:UT5E04_VeronicaAlvarezUT5E04_VeronicaAlvarez  5   	   *    $UT5E04_VeronicaAlvarez.ReservaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:UT5E04_VeronicaAlvarez     5   	     � Title$  Crear Reserva��5   	   $	��280��6   $	��520��6,    � 
ResizeMode$ NoResize=�68   .��5	      � .+�5
   
   �� $��Nombre:��6   $��Right=�6"   $��Bottom=�6>   $��0,0,415,207q�6Y   �� 5   
   -   5         ��Name$ 	txtNombre��5      $��Right=�6%   $��Bottom=�6A   $��
0,0,40,209q�6\   $	��360��6p   �� 5   
   $��
Teléfono:��6   $��Right=�6$   $��Bottom=�6@   $��0,0,185,177q�6[   �� 5   
   -   5        $ txtTelefono��5      $��Right=�6'   $��Bottom=�6C   $��
0,0,40,179q�6^   $	��140��6r   6~   �� 5   
   $��Fecha:��6   $��Right=�6!   $��Bottom=�6=   $��0,0,415,177q�6X   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtpFecha��5      $��Right=�6'   $��Bottom=�6C      SelectedDateFormat$ Short=�6^   $	��140��6y   $��0,0,260,177q�6�   �� 5   
   $��Asiste:��6   $��Right=�6"   $��Bottom=�6>   $��0,0,185,147q�6Y   �� 5   
   -   5         ��Name$ cbAsiste��5      $��Right=�6%   $��Bottom=�6A   $��0,0,165,150q�6\   �� 5   
   $��Comensales:��6   $��Right=�6&   $��Bottom=�6B   $��0,0,415,147q�6]   �� 5   
   -   5        $ txtComensales��5      $��Right=�6)   $��Bottom=�6E   $��0,0,260,149q�6`   $	��140��6u   6�   �� 5   
   $��Observaciones:��6   $��Right=�6)   $��Bottom=�6E   $��0,0,390,100q�6`   �� 5   
   -   5        $ txtObservaciones��5      $��Right=�6,   $��Bottom=�6H   $��	0,0,15,45q�6c   $	��470��6v   $��50��6�   �� 5   
   $��Cancelar��6    �� IsCancel . $��Right=�64   $��Bottom=�6P   $��20��6k   $��70��6w   $��	0,0,15,15q�6�   �� 5   
   -   5        $��Aceptar��5       �� 	IsDefault . $��Right=�64   $��Bottom=�6P   $��20��6k   $��70��6w   $��
0,0,100,15q�6�   6�   5      5      