   M S B A M L   `   `   `  ����B  >Semana4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Semana4.ViewSemana4.View  5   	       Semana4.View.ManCategoria   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Semana4.View     5   	   -   5          �Name$  myWindow��5	   	    � Title$ ManCategoria��5   	   $	��450��6   $	��800��6+    � 	Resources 5
       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ Center=�64   �� 5       � ��$
 75px��6&   �� 5       � ��$ 14(�6)   5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��485* �6   �� 5      $
��307* �6   .+�5   
   �� $��2��6   .+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��ID��6   �� 5      -   5         ��Name$ lblID��5      $	��200��6>   ��6'   �� *ID+6>   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Nombre��6   �� 5      -   5        	 ��Name$	 	txtNombre��5      $	��200��6E   ��6-   �� *Nombre+6E   5      �� 5      $ 
Horizontal=�6   .+�5       �� $��Descripcion��6   �� 5!      -   5        $	 txtDescripcion��5!      $	��200��6O   ��62   �� *Descripcion+6O   5"      �� 5#      $ 
Horizontal=�6   .+�5$      �� -   5        
 ��Name$
 	btnGrabar��5$      $��8 8 0 0q�6�   ��6,   �� *GrabarCommand+��6N   ��  �� ElementName$ myWindow��.��6�   Grabar6�   �� 5%      -   5        $
 btnEliminar��5%      $��8 8 0 0q�6R   ��6.   �� *EliminarCommand+.��6c   
Eliminar6m   �� 5&      -   5        $
 	btnCerrar��5&      $��8 8 0 0q�6�   ��6,   �� *CerrarCommand+��6N   �� $ myWindow��.��6�   Cerrar6�   5'      5(      5)      5*      