 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 u s i n g   S w i n G a m e S D K ;  
  
 / / /   < s u m m a r y >  
 / / /   T h e   E n d i n g G a m e C o n t r o l l e r   i s   r e s p o n s i b l e   f o r   m a n a g i n g   t h e   i n t e r a c t i o n s   a t   t h e   e n d  
 / / /   o f   a   g a m e .  
 / / /   < / s u m m a r y >  
  
 s t a t i c   c l a s s   E n d i n g G a m e C o n t r o l l e r  
 {  
  
 	 / / /   < s u m m a r y >  
 	 / / /   D r a w   t h e   e n d   o f   t h e   g a m e   s c r e e n ,   s h o w s   t h e   w i n / l o s e   s t a t e  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   s t a t i c   v o i d   D r a w E n d O f G a m e ( )  
 	 {  
 	 	 D r a w F i e l d ( C o m p u t e r P l a y e r . P l a y e r G r i d ,   C o m p u t e r P l a y e r ,   t r u e ) ;  
 	 	 D r a w S m a l l F i e l d ( H u m a n P l a y e r . P l a y e r G r i d ,   H u m a n P l a y e r ) ;  
  
 	 	 i f   ( H u m a n P l a y e r . I s D e s t r o y e d )   {  
 	 	 	 S w i n G a m e . D r a w T e x t L i n e s ( " Y O U   L O S E ! " ,   C o l o r . W h i t e ,   C o l o r . T r a n s p a r e n t ,   G a m e F o n t ( " A r i a l L a r g e " ) ,   F o n t A l i g n m e n t . A l i g n C e n t e r ,   0 ,   2 5 0 ,   S w i n G a m e . S c r e e n W i d t h ( ) ,   S w i n G a m e . S c r e e n H e i g h t ( ) ) ;  
 	 	 }   e l s e   {  
 	 	 	 S w i n G a m e . D r a w T e x t L i n e s ( " - -   W I N N E R   - - " ,   C o l o r . W h i t e ,   C o l o r . T r a n s p a r e n t ,   G a m e F o n t ( " A r i a l L a r g e " ) ,   F o n t A l i g n m e n t . A l i g n C e n t e r ,   0 ,   2 5 0 ,   S w i n G a m e . S c r e e n W i d t h ( ) ,   S w i n G a m e . S c r e e n H e i g h t ( ) ) ;  
 	 	 }  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   H a n d l e   t h e   i n p u t   d u r i n g   t h e   e n d   o f   t h e   g a m e .   A n y   i n t e r a c t i o n  
 	 / / /   w i l l   r e s u l t   i n   i t   r e a d i n g   i n   t h e   h i g h s S w i n G a m e .  
 	 / / /   < / s u m m a r y >  
 	 p u b l i c   s t a t i c   v o i d   H a n d l e E n d O f G a m e I n p u t ( )  
 	 {  
 	 	 i f   ( S w i n G a m e . M o u s e C l i c k e d ( M o u s e B u t t o n . L e f t B u t t o n )   | |   S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ R E T U R N )   | |   S w i n G a m e . K e y T y p e d ( K e y C o d e . V K _ E S C A P E ) )   {  
 	 	 	 R e a d H i g h S c o r e ( H u m a n P l a y e r . S c o r e ) ;  
 	 	 	 E n d C u r r e n t S t a t e ( ) ;  
 	 	 }  
 	 }  
  
 }  
 