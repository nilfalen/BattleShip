u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 s t a t i c   c l a s s   G a m e L o g i c  
 {  
 	 p u b l i c   s t a t i c   v o i d   M a i n ( )  
 	 {  
 	 	 / / O p e n s   a   n e w   G r a p h i c s   W i n d o w  
 	 	 S w i n G a m e . O p e n G r a p h i c s W i n d o w ( " B a t t l e   S h i p s " ,   8 0 0 ,   6 0 0 ) ;  
  
 	 	 / / L o a d   R e s o u r c e s  
 	 	 L o a d R e s o u r c e s ( ) ;  
  
 	 	 S w i n G a m e . P l a y M u s i c ( G a m e M u s i c ( " B a c k g r o u n d " ) ) ;  
  
 	 	 / / G a m e   L o o p  
 	 	 d o   {  
 	 	 	 H a n d l e U s e r I n p u t ( ) ;  
 	 	 	 D r a w S c r e e n ( ) ;  
 	 	 }   w h i l e   ( ! ( S w i n G a m e . W i n d o w C l o s e R e q u e s t e d ( )   = =   t r u e   |   C u r r e n t S t a t e   = =   G a m e S t a t e . Q u i t t i n g ) ) ;  
  
 	 	 S w i n G a m e . S t o p M u s i c ( ) ;  
  
 	 	 / / F r e e   R e s o u r c e s   a n d   C l o s e   A u d i o ,   t o   e n d   t h e   p r o g r a m .  
 	 	 F r e e R e s o u r c e s ( ) ;  
 	 }  
 }  
 