   M S B A M L   `   `   `  ����J  FEntityFramework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EntityFramework.ViewsEntityFramework.Views  5      U/clr-namespace:EntityFramework.Models.ViewModels!EntityFramework.Models.ViewModels  5      )    #EntityFramework.Views.Viewcustomers   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:EntityFramework.Views     5      E	viewModel/clr-namespace:EntityFramework.Models.ViewModels     5      .��5
      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��Customers list��6   $��0��6*   $��24(�67   $
��Bold"�6E   $
��auto��6W   $
��80 0q�6d   �� 5   
   -   5         ��Name$ lvCustomers��5       � DataContext$% EntityFramework.Models.Customer��6(   $��1��6V   
������ $��Stretch=�6|   $��Stretch=�6�   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $
��0.5* �6/   �� 5      $��1* �6/   �� 5      $��1* �6/   �� 5      $
��1.5* �6/   .+�5      �� $��0��6$   ��64   �� *Id+�� 5      $��1��6$   ��64   �� *CustomerFullName+�� 5      $��3��6$   ��64   �� *Email+�� 5      $��2��6$   ��64   �� *PhoneNumber+5       5!      5#      5$      5%      