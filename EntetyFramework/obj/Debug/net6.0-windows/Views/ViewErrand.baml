   M S B A M L   `   `   `  ����J  FEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EntityFramework.ViewsEntityFramework.Views  5      &     EntityFramework.Views.ViewErrand   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:EntityFramework.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Errand List��6   $��0��6'   $��24(�64   $
��Bold"�6B   $
��auto��6T   $
��80 0q�6a   � 5   
    � ColumnDefinitions 5      �� 5      $
��0.5* �6#   �� 5      $��1* �6#   �� 5      $
��1.5* �6#   �� 5      $��1* �6#   �� 5      $��2* �6#   .+�5      �� $��0��6   $��5 30 0 0q�6(   $
��Left=�6:   $��1��6U   Id6f   �� 5      $��1��6   $��0 30 0 0q�6(   $
��Left=�6:   $��1��6U   Titel6j   �� 5      $��2��6   $��0 30 0 0q�6(   $
��Left=�6:   $��1��6U   Time Created6q   �� 5      $��3��6   $��0 30 0 0q�6(   $
��Left=�6:   $��1��6U   Status6k   �� 5      $��4��6   $��0 30 0 0q�6(   $
��Left=�6:   $��1��6U   Customer Email6s   5      �� 5    
   -   5         ��Name$ 	lvErrands��5        � DataContext$% EntityFramework.Models.Customer��6&   $��2��6T   
������ $��Stretch=�6z   $��Stretch=�6�   ��5#      �� 5%      .R�5&      �  5'      �� 5(      $
��0.5* �6/   �� 5)      $
��1.5* �6/   �� 5*      $��1* �6/   �� 5+      $��1* �6/   �� 5,      $��2* �6/   .+�5/      �� $��0��6$   ��64   �� *Id+�� 50      $��1��6$   ��64   �� *ErrandTitel+�� 51      $��2��6$   $��
-50 0 0 0 q�6P   ��64   �� *
ErrandTime+6P   �� 52      $��3��6$   ��64   �� *ErrandStatus+�� 53      $��4��6$   ��64   �� *Customer.Email+54      55      57      59      5:      