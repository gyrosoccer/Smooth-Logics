   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5   	   K GMVVMsmoothlogics, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MVVMsmoothlogicsMVVMsmoothlogics 5   	   !   MVVMsmoothlogics.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   	   Hscm8clr-namespace:System.ComponentModel;assembly=WindowsBase      5   	   0localclr-namespace:MVVMsmoothlogics      5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��525��6)    � SizeToContent$ WidthAndHeight=�65    � 
ResizeMode$ NoResize=�6T    � DataContext 5      +  %MVVMsmoothlogics.ContactListViewModel  5	   
    � 	Resources 5         SortedItems �� Source �� SortDescriptions+   %System.ComponentModel.SortDescription   PropertyName��%n   &	        �� 5   
    6   �� *
Contacts+ 5        5      $ ContactName��6&   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   	 � ColumnDefinitions	 5   
   �� 5      $
��Auto �6   $	��151��6,   �� 5      $
��Auto �6   $	��112��6,   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5    
   �� -   5        $��	Listview1��5       $��1��6%   $��4��65   ��6B   �� 
 �� Source#
 [   �� SelectedItem 6�   �� *CurrentSelectedContact+��5!      �� 5"      .R�5#      �� .+�5$      �� ��6    �� *ContactName+5%      5&      5(      �� 5)   
   $��0��6   $��0��6    $
��Name��6-   �� 5*   
   $��0��6   $��2��6    $��Address��6-   �� 5+   
   $��1��6   $��0��6    $��Email��6-   �� 5,   
   $��1��6   $��2��6    $��Phone��6-   �� 5-   
   $��2��6   $��3��6    $��Filter (Not Implemented)��6-   �� 5.   
   $��2��6   $��1��6!   $��Add Contact��6.   ��6D   �� *UpdateContacts+�� 5/   
   $��2��6   $��2��6!   $��Delete Contact��6.   ��6G   �� *DeleteContact+�� 50   
   $
��Left=�6   $��23��6-   $��1��69   $��0��6F    �� TextWrapping$
 Wrap=�6V   $	��Top=�6�   $	��149��6�   ��6j   ��  �� ElementName$ 	Listview1�� �� Path$ SelectedItem.ContactName�6�   �� 51   
   $
��Left=�6   $��23��6-   $��3��69   $��0��6F   $
 Wrap=�6V   $	��Top=�6�   $	��149��6�   ��6j   �� $ 	Listview1��$! SelectedItem.ContactAddress�6�   �� 52   
   $
��Left=�6   $��23��6-   $��1��69   $��1��6F   $
 Wrap=�6V   $	��Top=�6�   $	��149��6�   ��6j   �� $ 	Listview1��$ SelectedItem.ContactEmail�6�   �� 53   
   $
��Left=�6   $��23��6-   $��3��69   $��1��6F   $
 Wrap=�6V   $	��Top=�6�   $	��149��6�   ��6j   �� $ 	Listview1��$ SelectedItem.ContactPhone�6�   �� 54   
   -   5        $��TextBoxFilter��54   �   $
��Left=�6   $��23��6-   $��4��69   $��2��6F   $
 Wrap=�6V   $	��Top=�6�   $	��149��6�   ��6j   �� *FilteredItems+ �� UpdateSourceTrigger$ PropertyChanged=�6�   55      56      