   M S B A M L   `   `   `  ����A  =MyCalc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyCalcMyCalc  5          MyCalc.HomeDataAcces   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:MyCalc     5        N� Title$  HomeDataAcces��5	      .��5
      � -   5         � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $��1* �6   ��5    
   �� 5!       �� ImageSource$ Resources/background.jpg��6    �� Opacity$	 0.9Q�6B   .+�5$   
   �� -   5        $��peopleFoundListBox��5$   X   $��1��6   $��0��6   $	��500��6/   $��Center=�6;   $��	0,10,0,10q�5%      $��25(�6%   
����ح�63   �� 5'   
   -   5        $��lastNameTextBox��5(      $��2��5'      $��0��6   $	��200��6/   $��35��6;   $��Center=�6G   $��200,10,0,10q�6d   $��25(�5(   )   
����ح�6Q   �� 5*   
   -   5        $��lastNameLabel��5+   <   $��2��5*      $��0��6   $	��200��6-   $��50��69   $��Center=�6E   
�������$��	0,0,200,0q�5+      
������ $��25(�6Q   $��Center=�6_   .��6�   Last Name :5-      �� 5/   
   $��0��6   $��0��6   $	��200��6-   $��50��69   $��Center=�6E   
������ $��25(�50   *   $��Center=�68   
�������.��6o   
Acces Data52      �� 54   
   -   5        $��searchButton��54      $��3��6%   $��0��62   $	��150��6B   $��25��6N   
����ح� J� Opacity$ .9Q�6q   $��Center=�55      $��Search��6.   $��1,1,1,1q�6?   6P   �� 57   
   -   5        $��InsertButton��57      $��3��6%   $	��100��62   $��25��6>   
����ح�$	 0.9Q�6a   $��Center=�58      $��Insert��6.   $��2��6Y   �� 59   
   -   5        $��backButton_Copy��59      $��0��6(   $��0��65   $��55��6E   
����ح�$��Right=�5:      $	��Top=�6)   $��35��6A   $	 0.5Q�6N   .��5;      �� $ ��Resources/close_button.png��6   $��Uniform=�68   $
 0.80Q�6K   5<      5=      5>      