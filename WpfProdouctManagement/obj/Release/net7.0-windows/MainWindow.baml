   M S B A M L   `   `   `  ���� P  LWpfProdouctManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:WpfProdouctManagementWpfProdouctManagement  &     WpfProdouctManagement.MainWindow   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5local#clr-namespace:WpfProdouctManagement       � Title$  
MainWindow��$	��700��$
��1200��.���  � ColumnDefinitions �� $
��auto ��� $��* �.+��� $��0��$��2q�
�������$	��250��$
��Left=�$��2q�
�������._��� .+��� -   $��btnHome��$��20,30q����#3e454c$��50��
�������$��22(�.��Home�� -   $��btnEmolyees��$��20,30q����#3e454c$��50��
�������$��22(�.��
Emolyees�� -   $��btnCustomers��$��20,30q����#3e454c$��50��
�������$��22(�.��	Customers�� -   $��
btnProducs��$��20,30q����#3e454c$��50��
�������$��22(�.��	Producs�� $��10,40q�$	��150��$	��150��$��Resources/Untitled.png���� -   $��	HomePanel��$��1��$��2q�$y�Visible=�
�������$��Stretch=�$��2q�
���   �._��� $��Stretch=�
�������.+��� $��42(�$��0,50,0,0q�$��Center=�$
��Bold"�$��Times New Roman)�.��Wellcome to my app�� $��Resources/1.jpg���� -   $��EmployeesPanel��$��1��$��2q�$y�	Collapsed=�
�������$��Stretch=�$��2q�
���   �._��� $��Stretch=�
�������$��15q�.+�&   System.Windows.Controls.DataGrid  -   $��EmplyessGrid��$��5q�   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    CanUserAddRows$ False��   MinColumnWidth$	 100Q�   CanUserResizeColumns$
 True��� $��5q� � RowDefinitions �� $	��150 ��� $��* �.+�� $��5q�$��0��.+��� $��2q�$
��Bold"�.��Detailed Info:�� -   $��EmployeeLabel��$��2q�$	��---��]� $��Center=�$��5q�$��1��.+��� -	   $��btnAddEmployee��$��10q�$��50��$	��150��
������.��Add Employee�� -
   $��btnDeleteEmployee��$��10q�$��50��$	��150��
���r���.��Delete�� -   $��btnEditEmployee��$��10q�$��50��$	��150��
�������.��Edit�� -   $��CostomersPanel��$��1��$��2q�$y�	Collapsed=�
�������$��Stretch=�$��2q�
���   �._��� $��Stretch=�
�������$��15q�.+�  -   $��CustomersGrid��$��5q�$ * $ False��$	 100Q�$
 True��� $��5q� �� $	��150 ��� $��* �.+�� $��5q�$��0��.+��� $��2q�$
��Bold"�.��Detailed Info:�� -   $��CustomerLabel��$��2q�$	��---��]� $��Center=�$��5q�$��1��.+��� -   $��btnAddCustomer��$��10q�$��50��$	��150��
������.��Add Customer�� -   $��btnDeleteCustomer��$��10q�$��50��$	��150��
���r���.��Delete�� -   $��btnEditCustomer��$��10q�$��50��$	��150��
�������.��Edit�� -   $��ProductsPanel��$��1��$��2q�$y�	Collapsed=�
�������$��Stretch=�$��2q�
���   �._��� $��Stretch=�
�������$��15q�.+�  -   $��ProductGrid��$��5q�$ * $ False��$
 True��� $��5q� �� $	��150 ��� $��* �.+�� $��5q�$��0��.+��� $��2q�$
��Bold"�.��Detailed Info:�� -   $��ProductLabel��$��2q�$	��---��]� $��Center=�$��5q�$��1��.+��� -   $��btnAddProduct��$��10q�$��50��$	��150��
������.��Add Customer�� -   $��btnDeleteProduct��$��10q�$��50��$	��150��
���r���.��Delete�� -   $��btnEditProduct��$��10q�$��50��$	��150��
�������.��Edit