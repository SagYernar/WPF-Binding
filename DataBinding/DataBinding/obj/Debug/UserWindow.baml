   M S B A M L   `   `   `  ����F  BDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:DataBindingDataBinding  5   	       DataBinding.UserWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:DataBinding     5   	     � Title$  
UserWindow��5   	   $	��300��6   $	��300��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��	usersGrid��5
         AutoGenerateColumns .  $
��Left=�6@   $	��153��6[   $	��Top=�6h   $	��292��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6A      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ Id�6Z     5      $ 
Логин��6D   $	 50* 6S    6%   �� $ Login�6a     5      $ Пароль��6G   $	 50* 6W    6%   �� $ Password�6e   5      �� 5   
   -   5         ��Name$ loginTextBox��5      $
��Left=�6(   $��23��6C   $��
68,194,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5        	 ��Name$	 changeButton��5      $��Change��6'   $
��Left=�68   $��193,195,0,0q�6S   $	��Top=�6h   $��75��6�   6�   �� 5   
   $��Login��6   $
��Left=�6    $��
25,191,0,0q�6;   $	��Top=�6O   5      5      