   M S B A M L   `   `   `  ����S  OAntras_Praktinias_Darbas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Antras_Praktinias_Darbas.PagesAntras_Praktinias_Darbas.Pages  5      1    +Antras_Praktinias_Darbas.Pages.Page_Teacher   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Antras_Praktinias_Darbas.Pages     5        N� Title$  Page_Teacher��5      $	��800��5      $	��800��6   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5       $	��10* �6   .+�5$   
   �� $��10��6   ���#c6c6c66)   �� 5%   
   $��1��6   $��9��6!   $��10��62   ���#e8d7896G   �� 5*   
   -   5         ��Name$ Text_TeacherName��5*      $��1��6.   $��6��6>   $��Sample Text��6R   $��32(�6e   $
��Bold"�6s   $��Center=�6�   $��Center=�6�   �� 5+   
   -   5        $��8��5+      $��2��6!   $��LOG OUT��65   $��20(�6G   $
��Bold"�6U   ���#cf4646$��15q�6|   6�   �� 51   
   $��2��6   $��3��6!   $��Subject:��65   $��32(�6E   $
��Bold"�6S   $��Right=�6e   $��Center=�6�   $��0,0,15,0q�6�   �� 52   
   -   5         ��Name$ ComboBox_Subject��52      $��2��6-   $��3��6:   $��6��6J   $��26(�6^   $��Center=�6l   $��10q�6�   ��53      �� 54      .R�55      �� ��6    �� *SubjectName+56      58      �� 5;   
   $��3��6   $��3��6!   $��Group:��65   $��32(�6C   $
��Bold"�6Q   $��Right=�6c   $��Center=�6   $��0,0,15,0q�6�   �� 5<   
   -   5        $ ComboBox_Group��5<      $��3��6+   $��3��68   $��6��6H   $��26(�6\   $��Center=�6j   $��10q�6�   ��5=      �� 5>      .R�5?      �� ��6    �� *	GroupName+5@      5B      �� 5E   
   $��4��6   $��3��6!   $��Student:��65   $��32(�6E   $
��Bold"�6S   $��Right=�6e   $��Center=�6�   $��0,0,15,0q�6�   �� 5F   
   -   5        $ ComboBox_Student��5F      $��4��6-   $��3��6:   $��6��6J   $��26(�6^   $��Center=�6l   $��10q�6�   ��5G      �� 5H      .R�5I      �� ��6    �� *	FirstName+5J      5L      �� 5O   
   -   5         ��Name$ ListBox_Grades��5O      $��5��6*   $��3��67   $��1��6H   $��8��6X   $��Stretch=�6l   $��10q�6�   ��5P      �� 5Q      .R�5R      �  5S      �� 5T      $	��75* �6/   �� 5U      $	��25* �6/   .+�5X      �� $��0��6$   ��64   �� *Score+�� 5Y      $��1��6$   ��64   �� *	GradeType+5Z      5[      5]      �� 5_   
   -   5        $��8��5_      $��1��6   $��2��6.   $��CREATE��6B   $��20(�6S   $
��Bold"�6a   ���#5bcf46$��10q�6�   6�   �� 5`   
   -   5        $��8��5`      $��4��6   $��2��6.   $��CHANGE��6B   $��20(�6S   $
��Bold"�6a   ���#ffc58e$��10q�6�   6�   �� 5a   
   -	   5        $��8��5a      $��7��6   $��2��6.   $��DELETE��6B   $��20(�6S   $
��Bold"�6a   ���#cf4646$��10q�6�   6�   5b      5c      