   M S B A M L   `   `   `  ����d  `PresentationFramework.Classic, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35jMclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.ClassicMicrosoft.Windows.Themes  5      e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089iMclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.RibbonSystem.Windows.Controls 5   	   I EBsecureMailing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BsecureMailingBsecureMailing 5	   	      BsecureMailing.ViewMail   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   rMicrosoft_Windows_ThemesMclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Classic     5      c	RibbonWinMclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Ribbon     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:BsecureMailing     5	   	     � Title$  Untitled-Message (HTML)��5       � WindowState$ 	Maximized=�6(    �� TextAlignment$ Center=�6A   ���#E9EDF1 � WindowStartupLocation$ CenterScreen=�6x   $
��10px(�6�   $��roboto)�6�    � 	Resources 5         OutlookButtonForeground �� Color  OutlookButtonBackground �� EndPoint �� 
StartPoint � Color	 � Offset  OutlookButtonHighlight  OutlookTabControlStyle
 �� 
TargetType �� Property �� Value5   /Microsoft.Windows.Themes.ClassicBorderDecorator   ClassicBorderBrush  OutlookTabItemStyle��%�  &	        &	 #     &	 �     &	 �    &	 �    �� 5   
   $ 	#FF204D89��6:   �� 5   
   $ 0.5,1&�6>   $ 0.5,0&�6O   .��5      � $ #F3F5F8��6   $	 0Q�6+   � 5      $ #F0F2F5��6   $
	 0.20Q�6,   � 5      $ #E7EAEE��6   $
	 0.53Q�6,   5      �� 5   
   $ 0.5,1&�6=   $ 0.5,0&�6N   .��5#      � $ 	#FFFFBD69��6   $	 0Q�6-   � 5'      $ 	#FFFFEBAA��6   $	 0.8000Q�6-   5)      �� 5+   
   "
 ��6/   .�5-      ��  � ��# �  6+   �� 5.       � �� �#DFE3E76+   �� 5/       � ��# Z 6,   �� 50       � ��$ 0q�60   �� 51       � ��$ 0q�6'   �� 52       �@��Padding$ 1q�6(   �� 53       � ��$ 10��6)   �� 54       � ��$ 10��6*   57      �� 59   
   "
 ��6,   .�5:      ��  �@��Padding$ 	12,2,12,2q�6(   �� 5<       � ��# � ��6+   5?      5B      .��5D      �  � RowDefinitions 5E   
   �� 5F      $
��Auto �6   6,   �� 5G      $
��0.3* �6   6,   �� 5H      $
��Auto �6   6,   �� 5I      $
��0.3* �6   6,   �� 5J      $	��80* �6   6+   .+�5L   
   +  %System.Windows.Controls.Ribbon.Ribbon  ���#333333$��10(�6'   $��	0,-22,0,0q�65      HelpPaneContent 5N      1  +System.Windows.Controls.Ribbon.RibbonButton  5O         SmallImageSource$ /Images/help.png��6      QuickAccessToolBar 5R      =  7System.Windows.Controls.Ribbon.RibbonQuickAccessToolBar  5S      .@�5T        -   5          Name$
 Save��5T   #   $ /Images/save.png��62   6  0System.Windows.Controls.Ribbon.RibbonSplitButton  5U      -   5          Name$
 Undo��5U   (   5  /System.Windows.Controls.Ribbon.RibbonMenuButton   SmallImageSource$ /Images/undo.png��67   .@�5V      8  2System.Windows.Controls.Ribbon.RibbonSplitMenuItem  $��Undo 1��6.     5W      $��Undo 2��6.     5X      $��Undo 3��6.   5Y        5Z      -   5        $
 Redo��5Z   (   $ /Images/redo.png��66   .@�5[        $��Redo 1��6.     5\      $��Redo 2��6.   5]      5^         ApplicationMenu 5a      :  4System.Windows.Controls.Ribbon.RibbonApplicationMenu  5b         KeyTip$ F��6(   .@�5c      >	  8System.Windows.Controls.Ribbon.RibbonApplicationMenuItem	  $��Options��60   3
  -System.Windows.Controls.Ribbon.RibbonMenuItem 
  ImageSource$ /Images/options.png��6A   	  5d      $
��Exit��60   $ /Images/quit.png��6>   5e      .@�5i      .  (System.Windows.Controls.Ribbon.RibbonTab  $��Message��6   .@�5x      0  *System.Windows.Controls.Ribbon.RibbonGroup  $��delete��6   .@�5y           Label$ Ignore��6'   $ /images/email_delete.png��66   $ V��6c   5{        5}      $
 junk��6'   $ /Images/user1-delete3.png��64   $ V��6b   .@�5~      
  6+   5        5�         LargeImageSource$ /Images/deletered.png��6$      Label$ Delete ��6M      KeyTip$ N��6]   6k   5�        5�      $��Reply��6   .@�5�        -   5        $ btnreply��5�   $   $ Reply��6M   $ /images/mail_reply.png��6[   6�     5�      $ 	Reply All��6#   $( "/images/BT_message_out-128 (1).png��65   $ V��6l   5�        5�      $ Forward��6#   $ /images/mail-go.png��63   $ V��6[   5�        5�      $ /images/meeting.png��6'   $ V��6O   5�        5�      $ /images/IM.png��6'   $ V��6J   .@�5�      
  6+   5�        5�      $ /images/meeting2.png��6'   $ V��6P   .@�5�      
  6+   5�      5�        5�      $
��Read��6   .@�5�        $ /Images/mail.png��6#   $ Read / UnRead��6G   $ N��6]   6k   �� 5�      $��/Images/documents-128.png��6   $
��20px��6?   $
��20px��6L   $
��15,8q�6Z   6j   �� 5�      $��
Categorize��6    $��50��62   $ Center=�6=   $
��Wrap=�6T   6l     5�      $  /Images\folow-flag-128.png��6#   $ 	Follow Up��6Q   $ N��6c   6q   5�        5�      $
��Move��6   .@�5�        $ /Images/filetofolder.png��6#   $
 Move��6O   $ N��6\   6j     5�      $ /Images/folder.png��6#   $ Rules��6I   $ N��6W   6e   5�        5�      $
��Find��6   .@�5�      �� $��Find a Contact��6   
�������6I     5�      $( "/Images/mail_read-filter-2-128.png��6#   $ Filter Email��6Z   $ N��6o   6}     5�      $ /Images/address-book.png��6#   $ Address Book��6P   $ N��6e   6s   5�        5�      -   5          Name$ ClipboardGroup��5�      $��Send / Receive��66   .@�5�           LargeImageSource$- '/Images/envelope_mark_as_unread-128.png��6'   $ Send/Recieve All Folders��6b   $ V��6�   5�      5�      5�      5�      � 5�   
   -   5        $��UIPanel��5�      $��1��6   ��5�      �� 5�      $ 0.5,1&�6&   $ 0.5,0&�67   .��5�      � $ Black��6#   $	 0.435Q�63   � 5�      $ Silver��6#   $		 0.9Q�64   � 5�      $ Silver��6#   $		 0.8Q�64   � 5�      $ #8B9097��6#   $	 0.5334Q�63   � 5�      $ #8B9097��6#   $	 0.235Q�63   5�      5�      � 5�   
   ���#E9EDF1$��2��6%   $��Stretch=�64   .+�5�      �� $��Stretch=�6    �� Orientation$ Vertical=�68   .+�5�      � $��5q�6    5�      �� 5�      $	��20* �6(   68   �� 5�      $��2 �6(   66   �� 5�      $	��20* �6(   67   �� 5�      $��2 �6(   67   �� 5�      $	��20* �6(   68   �� 5�      $��2 �6(   67   �� 5�      $	��20* �6(   68   .+�5�      � $��0��6    � ColumnDefinitions 5�      �� 5�      $��4* �6/   6<   �� 5�      $��2* �6/   6<   �� 5�      $	��90* �6/   6>   .+�5�      ��   �� CornerRadius$  2��6!   $��20��63   $
��Left=�6?   $��0��6Z   ._�5�      �� $��From :��6(   $��Center=�66   $
��Left=�6Q   $ Center=�6m   6�   5�      �� 5�      $ 
Horizontal=�6%   $��2��6>   $
��Left=�6N   $��Center=�6i   .+�5�      �� $��/Images/Green_button.png��6$   $	��8px��6F   $	��8px��6R   $��0,0,5,0q�6_   6s   �� 5�      -   5        ! ��Name$! txtEMailFrom��5�   (   $��Suresh B��6>   6P   �� 5�      <6/   �� 5�      -   5        $! 
txtEMailID��5�   (   $��Stretch=�6<   
���   �$��suresh.burra@gmail.com��6n   6�   �� 5�      >6/   5�      5�      � 5�      $��2��6    5�      �� 5�      $��4* �6/   6<   �� 5�      $��2* �6/   6<   �� 5�      $	��90* �6/   6>   .+�5�      �� $  2��6!   $��20��63   $
��Left=�6?   $��0��6Z   
�������$��0q�6   ._�5�      �� $
��To :��6(   $��Center=�64   $
��Left=�6O   $ Center=�6k   6�   5�      �� 5�      $ 
Horizontal=�6%   $��2��6>   $
��Left=�6N   $��Center=�6i   .+�5�      �� $��/Images/cube.png��6$   $	��8px��6>   $	��8px��6J   $��0,0,5,0q�6W   6k   �� 5�      -	   5        $! 
txtEmailTo��5�   (   $��Stretch=�6<   
���   �$��sureshburra@ptgindia.com��6n   6�   5�      5�      � 5�      $��4��6    5�      �� 5�      $��4* �6/   6<   �� 5�      $��2* �6/   6<   �� 5�      $	��90* �6/   6>   .+�5�      �� $  3��6!   $��20��63   $
��Left=�6?   $��0��6Z   
�������$��0q�6   ._�5     �� $
��Cc :��6(   $��Center=�64   $
��Left=�6O   $ Center=�6k   6�   5	     �� 5
     -
   5        $! txtCC��5
  $   $
 Left=�63   $��2��6H   6Z   5     � 5     $��6��6    5     �� 5     $��5* �6/   6<   �� 5     $��1* �6/   6<   �� 5     $	��90* �6/   6>   .+�5     �� $  1��6!   $��20��63   $
��Left=�6?   $��0��6Z   
�������$��0q�6   ._�5     �� $��	Subject :��6(   $��Center=�69   $
��Left=�6T   $ Center=�6p   6�   5      �� 5!     $ 
Horizontal=�6%   $��2��6>   $
��Left=�6N   $��Center=�6i   .+�5#     �� -   5        $! 
txtSubject��5#  (   $��Suresh B��6<   6N   5%     5&     5'     59     5;     �� 5=  
   $��10q�6   $��4��6   
�������
�������$	��0.5q�6T   ._�5?     (  "System.Windows.Controls.WebBrowser  -   5        "  Name$" 	wbbrowser��5?     6/   5@     5D     5E     