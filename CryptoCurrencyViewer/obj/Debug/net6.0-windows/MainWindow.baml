   M S B A M L   `   `   `  ����  CryptoCurrencyViewer%    CryptoCurrencyViewer.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  CryptoCurrenciesViewer��5   	   $	��500��6(   $	��600��65   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5	      $
��Auto �6   ��5   
   �� 5       �� EndPoint$ 0.1,1&�6"    �� 
StartPoint$ 0.1,0.4&�63   .��5      �  � Color$ 	#FF2785CB��6    � Offset$ 1Q�61   � 5      $ White��6   $	 0.4Q�6-   5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $
��Left=�6.   $	��Top=�6I   $��
10,10,0,10q�6a   .+�5      �� $��Images\cryptoicon.png��6   $��40��63   $��40��6>   $��0,0,10,0q�6J   �� 5      $��CryptoCurrencies��6   $��24(�6/   $
��Bold"�6=   $��Center=�6O   5      �� 5   
   -   5        $��searchTextBox��5      $��0��6   $��267,28,10,10q�64   $��30��6J   $��Center=�6V   $��5q�6x   �� 5   
   -   5        $��searchButton��5   /   $��0��6   $��Search��6   $��
0,28,10,10q�6^   $��30��6r   $��Right=�6~   $��5q�6�    � Cursor$
 Hand��6�   �� 5   
   -   5        $��cryptoListView��5       $��1��6   $��
-9,10,0,10q�66   ���	#00FFFFFF
���   � �� View 5      �� 5      .P�5      �� $
��Rank��6%   	 �� Width$	 50��63   
 �� DisplayMemberBinding
 6>   �� *Rank+�� 5      $
��Name��6%   $		 150��63   
 6?   �� *Name+�� 5      $��Price��6%   $		 150��64   
 6@   �� *Price+�� 5      $��
Market Cap��6%   $		 150��69   
 6E   �� *	MarketCap+�� 5      $��Change %��6%   $		 150��67   
 6C   �� *ChangePercent+5      5!      �� 5"   
   -   5        $��cryptoInfoButton��5"   2   $��2��6   $��	More Info��6   $��
10,10,0,20q�6i   $��30��6}   $
��Left=�6�   $��5q�6�   $
 Hand��6�   5#      5$      