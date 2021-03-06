 
 u s i n g   M i c r o s o f t . V i s u a l B a s i c ;  
 u s i n g   S y s t e m ;  
 u s i n g   S y s t e m . C o l l e c t i o n s ;  
 u s i n g   S y s t e m . C o l l e c t i o n s . G e n e r i c ;  
 u s i n g   S y s t e m . D a t a ;  
 u s i n g   S y s t e m . D i a g n o s t i c s ;  
 u s i n g   S w i n G a m e S D K ;  
  
 p u b l i c   s t a t i c   c l a s s   G a m e R e s o u r c e s  
 {  
  
 	 p r i v a t e   s t a t i c   v o i d   L o a d F o n t s ( )  
 	 {  
 	 	 N e w F o n t ( " A r i a l L a r g e " ,   " a r i a l . t t f " ,   8 0 ) ;  
 	 	 N e w F o n t ( " C o u r i e r " ,   " c o u r . t t f " ,   1 4 ) ;  
 	 	 N e w F o n t ( " C o u r i e r S m a l l " ,   " c o u r . t t f " ,   8 ) ;  
 	 	 N e w F o n t ( " M e n u " ,   " f f a c c e s s . t t f " ,   8 ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   L o a d I m a g e s ( )  
 	 {  
 	 	 / / B a c k g r o u n d s  
 	 	 N e w I m a g e ( " M e n u " ,   " m a i n _ p a g e . j p g " ) ;  
 	 	 N e w I m a g e ( " D i s c o v e r y " ,   " d i s c o v e r . j p g " ) ;  
 	 	 N e w I m a g e ( " D e p l o y " ,   " d e p l o y . j p g " ) ;  
  
 	 	 / / D e p l o y m e n t  
 	 	 N e w I m a g e ( " L e f t R i g h t B u t t o n " ,   " d e p l o y _ d i r _ b u t t o n _ h o r i z . p n g " ) ;  
 	 	 N e w I m a g e ( " U p D o w n B u t t o n " ,   " d e p l o y _ d i r _ b u t t o n _ v e r t . p n g " ) ;  
 	 	 N e w I m a g e ( " S e l e c t e d S h i p " ,   " d e p l o y _ b u t t o n _ h l . p n g " ) ;  
 	 	 N e w I m a g e ( " P l a y B u t t o n " ,   " d e p l o y _ p l a y _ b u t t o n . p n g " ) ;  
 	 	 N e w I m a g e ( " R a n d o m B u t t o n " ,   " d e p l o y _ r a n d o m i z e _ b u t t o n . p n g " ) ;  
  
 	 	 / / S h i p s  
 	 	 i n t   i   =   0 ;  
 	 	 f o r   ( i   =   1 ;   i   < =   5 ;   i + + )   {  
 	 	 	 N e w I m a g e ( " S h i p L R "   +   i ,   " s h i p _ d e p l o y _ h o r i z _ "   +   i   +   " . p n g " ) ;  
 	 	 	 N e w I m a g e ( " S h i p U D "   +   i ,   " s h i p _ d e p l o y _ v e r t _ "   +   i   +   " . p n g " ) ;  
 	 	 }  
  
 	 	 / / E x p l o s i o n s  
 	 	 N e w I m a g e ( " E x p l o s i o n " ,   " e x p l o s i o n . p n g " ) ;  
 	 	 N e w I m a g e ( " S p l a s h " ,   " s p l a s h . p n g " ) ;  
  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   L o a d S o u n d s ( )  
 	 {  
 	 	 N e w S o u n d ( " E r r o r " ,   " e r r o r . w a v " ) ;  
 	 	 N e w S o u n d ( " H i t " ,   " h i t . w a v " ) ;  
 	 	 N e w S o u n d ( " S i n k " ,   " s i n k . w a v " ) ;  
 	 	 N e w S o u n d ( " S i r e n " ,   " s i r e n . w a v " ) ;  
 	 	 N e w S o u n d ( " M i s s " ,   " w a t e r s h o t . w a v " ) ;  
 	 	 N e w S o u n d ( " W i n n e r " ,   " w i n n e r . w a v " ) ;  
 	 	 N e w S o u n d ( " L o s e " ,   " l o s e . w a v " ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   L o a d M u s i c ( )  
 	 {  
 	 	 N e w M u s i c ( " B a c k g r o u n d " ,   " h o r r o r d r o n e . m p 3 " ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   a   F o n t   L o a d e d   i n   t h e   R e s o u r c e s  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " f o n t " > N a m e   o f   F o n t < / p a r a m >  
 	 / / /   < r e t u r n s > T h e   F o n t   L o a d e d   w i t h   t h i s   N a m e < / r e t u r n s >  
  
 	 p u b l i c   s t a t i c   F o n t   G a m e F o n t ( s t r i n g   f o n t )  
 	 {  
 	 	 r e t u r n   _ F o n t s ( f o n t ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   a n   I m a g e   l o a d e d   i n   t h e   R e s o u r c e s  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " i m a g e " > N a m e   o f   i m a g e < / p a r a m >  
 	 / / /   < r e t u r n s > T h e   i m a g e   l o a d e d   w i t h   t h i s   n a m e < / r e t u r n s >  
  
 	 p u b l i c   s t a t i c   B i t m a p   G a m e I m a g e ( s t r i n g   i m a g e )  
 	 {  
 	 	 r e t u r n   _ I m a g e s ( i m a g e ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   a n   s o u n d   l o a d e d   i n   t h e   R e s o u r c e s  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " s o u n d " > N a m e   o f   s o u n d < / p a r a m >  
 	 / / /   < r e t u r n s > T h e   s o u n d   w i t h   t h i s   n a m e < / r e t u r n s >  
  
 	 p u b l i c   s t a t i c   S o u n d E f f e c t   G a m e S o u n d ( s t r i n g   s o u n d )  
 	 {  
 	 	 r e t u r n   _ S o u n d s ( s o u n d ) ;  
 	 }  
  
 	 / / /   < s u m m a r y >  
 	 / / /   G e t s   t h e   m u s i c   l o a d e d   i n   t h e   R e s o u r c e s  
 	 / / /   < / s u m m a r y >  
 	 / / /   < p a r a m   n a m e = " m u s i c " > N a m e   o f   m u s i c < / p a r a m >  
 	 / / /   < r e t u r n s > T h e   m u s i c   w i t h   t h i s   n a m e < / r e t u r n s >  
  
 	 p u b l i c   s t a t i c   M u s i c   G a m e M u s i c ( s t r i n g   m u s i c )  
 	 {  
 	 	 r e t u r n   _ M u s i c ( m u s i c ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   D i c t i o n a r y < s t r i n g ,   B i t m a p >   _ I m a g e s   =   n e w   D i c t i o n a r y < s t r i n g ,   B i t m a p > ( ) ;  
 	 p r i v a t e   s t a t i c   D i c t i o n a r y < s t r i n g ,   F o n t >   _ F o n t s   =   n e w   D i c t i o n a r y < s t r i n g ,   F o n t > ( ) ;  
 	 p r i v a t e   s t a t i c   D i c t i o n a r y < s t r i n g ,   S o u n d E f f e c t >   _ S o u n d s   =   n e w   D i c t i o n a r y < s t r i n g ,   S o u n d E f f e c t > ( ) ;  
  
 	 p r i v a t e   s t a t i c   D i c t i o n a r y < s t r i n g ,   M u s i c >   _ M u s i c   =   n e w   D i c t i o n a r y < s t r i n g ,   M u s i c > ( ) ;  
 	 p r i v a t e   s t a t i c   B i t m a p   _ B a c k g r o u n d ;  
 	 p r i v a t e   s t a t i c   B i t m a p   _ A n i m a t i o n ;  
 	 p r i v a t e   s t a t i c   B i t m a p   _ L o a d e r F u l l ;  
 	 p r i v a t e   s t a t i c   B i t m a p   _ L o a d e r E m p t y ;  
 	 p r i v a t e   s t a t i c   F o n t   _ L o a d i n g F o n t ;  
  
 	 p r i v a t e   s t a t i c   S o u n d E f f e c t   _ S t a r t S o u n d ;  
 	 / / /   < s u m m a r y >  
 	 / / /   T h e   R e s o u r c e s   C l a s s   s t o r e s   a l l   o f   t h e   G a m e s   M e d i a   R e s o u r c e s ,   s u c h   a s   I m a g e s ,   F o n t s  
 	 / / /   S o u n d s ,   M u s i c .  
 	 / / /   < / s u m m a r y >  
  
 	 p u b l i c   s t a t i c   v o i d   L o a d R e s o u r c e s ( )  
 	 {  
 	 	 i n t   w i d t h   =   0 ;  
 	 	 i n t   h e i g h t   =   0 ;  
  
 	 	 w i d t h   =   S w i n G a m e . S c r e e n W i d t h ( ) ;  
 	 	 h e i g h t   =   S w i n G a m e . S c r e e n H e i g h t ( ) ;  
  
 	 	 S w i n G a m e . C h a n g e S c r e e n S i z e ( 8 0 0 ,   6 0 0 ) ;  
  
 	 	 S h o w L o a d i n g S c r e e n ( ) ;  
  
 	 	 S h o w M e s s a g e ( " L o a d i n g   f o n t s . . . " ,   0 ) ;  
 	 	 L o a d F o n t s ( ) ;  
 	 	 S w i n G a m e . D e l a y ( 1 0 0 ) ;  
  
 	 	 S h o w M e s s a g e ( " L o a d i n g   i m a g e s . . . " ,   1 ) ;  
 	 	 L o a d I m a g e s ( ) ;  
 	 	 S w i n G a m e . D e l a y ( 1 0 0 ) ;  
  
 	 	 S h o w M e s s a g e ( " L o a d i n g   s o u n d s . . . " ,   2 ) ;  
 	 	 L o a d S o u n d s ( ) ;  
 	 	 S w i n G a m e . D e l a y ( 1 0 0 ) ;  
  
 	 	 S h o w M e s s a g e ( " L o a d i n g   m u s i c . . . " ,   3 ) ;  
 	 	 L o a d M u s i c ( ) ;  
 	 	 S w i n G a m e . D e l a y ( 1 0 0 ) ;  
  
 	 	 S w i n G a m e . D e l a y ( 1 0 0 ) ;  
 	 	 S h o w M e s s a g e ( " G a m e   l o a d e d . . . " ,   5 ) ;  
 	 	 S w i n G a m e . D e l a y ( 1 0 0 ) ;  
 	 	 E n d L o a d i n g S c r e e n ( w i d t h ,   h e i g h t ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   S h o w L o a d i n g S c r e e n ( )  
 	 {  
 	 	 _ B a c k g r o u n d   =   S w i n G a m e . L o a d B i t m a p ( S w i n G a m e . P a t h T o R e s o u r c e ( " S p l a s h B a c k . p n g " ,   R e s o u r c e K i n d . B i t m a p R e s o u r c e ) ) ;  
 	 	 S w i n G a m e . D r a w B i t m a p ( _ B a c k g r o u n d ,   0 ,   0 ) ;  
 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
  
 	 	 _ A n i m a t i o n   =   S w i n G a m e . L o a d B i t m a p ( S w i n G a m e . P a t h T o R e s o u r c e ( " S w i n G a m e A n i . j p g " ,   R e s o u r c e K i n d . B i t m a p R e s o u r c e ) ) ;  
 	 	 _ L o a d i n g F o n t   =   S w i n G a m e . L o a d F o n t ( S w i n G a m e . P a t h T o R e s o u r c e ( " a r i a l . t t f " ,   R e s o u r c e K i n d . F o n t R e s o u r c e ) ,   1 2 ) ;  
 	 	 _ S t a r t S o u n d   =   A u d i o . L o a d S o u n d E f f e c t ( S w i n G a m e . P a t h T o R e s o u r c e ( " S w i n G a m e S t a r t . o g g " ,   R e s o u r c e K i n d . S o u n d R e s o u r c e ) ) ;  
  
 	 	 _ L o a d e r F u l l   =   S w i n G a m e . L o a d B i t m a p ( S w i n G a m e . P a t h T o R e s o u r c e ( " l o a d e r _ f u l l . p n g " ,   R e s o u r c e K i n d . B i t m a p R e s o u r c e ) ) ;  
 	 	 _ L o a d e r E m p t y   =   S w i n G a m e . L o a d B i t m a p ( S w i n G a m e . P a t h T o R e s o u r c e ( " l o a d e r _ e m p t y . p n g " ,   R e s o u r c e K i n d . B i t m a p R e s o u r c e ) ) ;  
  
 	 	 P l a y S w i n G a m e I n t r o ( ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   P l a y S w i n G a m e I n t r o ( )  
 	 {  
 	 	 c o n s t   i n t   A N I _ X   =   1 4 3 ;  
 	 	 c o n s t   i n t   A N I _ Y   =   1 3 4 ;  
 	 	 c o n s t   i n t   A N I _ W   =   5 4 6 ;  
 	 	 c o n s t   i n t   A N I _ H   =   3 2 7 ;  
 	 	 c o n s t   i n t   A N I _ V _ C E L L _ C O U N T   =   6 ;  
 	 	 c o n s t   i n t   A N I _ C E L L _ C O U N T   =   1 1 ;  
  
 	 	 A u d i o . P l a y S o u n d E f f e c t ( _ S t a r t S o u n d ) ;  
 	 	 S w i n G a m e . D e l a y ( 2 0 0 ) ;  
  
 	 	 i n t   i   =   0 ;  
 	 	 f o r   ( i   =   0 ;   i   < =   A N I _ C E L L _ C O U N T   -   1 ;   i + + )   {  
 	 	 	 S w i n G a m e . D r a w B i t m a p ( _ B a c k g r o u n d ,   0 ,   0 ) ;  
 	 	 	 S w i n G a m e . D r a w B i t m a p P a r t ( _ A n i m a t i o n ,   ( i   /   A N I _ V _ C E L L _ C O U N T )   *   A N I _ W ,   ( i   %   A N I _ V _ C E L L _ C O U N T )   *   A N I _ H ,   A N I _ W ,   A N I _ H ,   A N I _ X ,   A N I _ Y ) ;  
 	 	 	 S w i n G a m e . D e l a y ( 2 0 ) ;  
 	 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
 	 	 }  
  
 	 	 S w i n G a m e . D e l a y ( 1 5 0 0 ) ;  
  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   S h o w M e s s a g e ( s t r i n g   m e s s a g e ,   i n t   n u m b e r )  
 	 {  
 	 	 c o n s t   i n t   T X   =   3 1 0 ;  
 	 	 c o n s t   i n t   T Y   =   4 9 3 ;  
 	 	 c o n s t   i n t   T W   =   2 0 0 ;  
 	 	 c o n s t   i n t   T H   =   2 5 ;  
 	 	 c o n s t   i n t   S T E P S   =   5 ;  
 	 	 c o n s t   i n t   B G _ X   =   2 7 9 ;  
 	 	 c o n s t   i n t   B G _ Y   =   4 5 3 ;  
  
 	 	 i n t   f u l l W   =   0 ;  
  
 	 	 f u l l W   =   2 6 0   *   n u m b e r   /   S T E P S ;  
 	 	 S w i n G a m e . D r a w B i t m a p ( _ L o a d e r E m p t y ,   B G _ X ,   B G _ Y ) ;  
 	 	 S w i n G a m e . D r a w B i t m a p P a r t ( _ L o a d e r F u l l ,   0 ,   0 ,   f u l l W ,   6 6 ,   B G _ X ,   B G _ Y ) ;  
  
 	 	 S w i n G a m e . D r a w T e x t L i n e s ( m e s s a g e ,   C o l o r . W h i t e ,   C o l o r . T r a n s p a r e n t ,   _ L o a d i n g F o n t ,   F o n t A l i g n m e n t . A l i g n C e n t e r ,   T X ,   T Y ,   T W ,   T H ) ;  
  
 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   E n d L o a d i n g S c r e e n ( i n t   w i d t h ,   i n t   h e i g h t )  
 	 {  
 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
 	 	 S w i n G a m e . D e l a y ( 5 0 0 ) ;  
 	 	 S w i n G a m e . C l e a r S c r e e n ( ) ;  
 	 	 S w i n G a m e . R e f r e s h S c r e e n ( ) ;  
 	 	 S w i n G a m e . F r e e F o n t ( _ L o a d i n g F o n t ) ;  
 	 	 S w i n G a m e . F r e e B i t m a p ( _ B a c k g r o u n d ) ;  
 	 	 S w i n G a m e . F r e e B i t m a p ( _ A n i m a t i o n ) ;  
 	 	 S w i n G a m e . F r e e B i t m a p ( _ L o a d e r E m p t y ) ;  
 	 	 S w i n G a m e . F r e e B i t m a p ( _ L o a d e r F u l l ) ;  
 	 	 A u d i o . F r e e S o u n d E f f e c t ( _ S t a r t S o u n d ) ;  
 	 	 S w i n G a m e . C h a n g e S c r e e n S i z e ( w i d t h ,   h e i g h t ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   N e w F o n t ( s t r i n g   f o n t N a m e ,   s t r i n g   f i l e n a m e ,   i n t   s i z e )  
 	 {  
 	 	 _ F o n t s . A d d ( f o n t N a m e ,   S w i n G a m e . L o a d F o n t ( S w i n G a m e . P a t h T o R e s o u r c e ( f i l e n a m e ,   R e s o u r c e K i n d . F o n t R e s o u r c e ) ,   s i z e ) ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   N e w I m a g e ( s t r i n g   i m a g e N a m e ,   s t r i n g   f i l e n a m e )  
 	 {  
 	 	 _ I m a g e s . A d d ( i m a g e N a m e ,   S w i n G a m e . L o a d B i t m a p ( S w i n G a m e . P a t h T o R e s o u r c e ( f i l e n a m e ,   R e s o u r c e K i n d . B i t m a p R e s o u r c e ) ) ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   N e w T r a n s p a r e n t C o l o r I m a g e ( s t r i n g   i m a g e N a m e ,   s t r i n g   f i l e N a m e ,   C o l o r   t r a n s C o l o r )  
 	 {  
 	 	 _ I m a g e s . A d d ( i m a g e N a m e ,   S w i n G a m e . L o a d B i t m a p ( S w i n G a m e . P a t h T o R e s o u r c e ( f i l e N a m e ,   R e s o u r c e K i n d . B i t m a p R e s o u r c e ) ,   t r u e ,   t r a n s C o l o r ) ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   N e w T r a n s p a r e n t C o l o u r I m a g e ( s t r i n g   i m a g e N a m e ,   s t r i n g   f i l e N a m e ,   C o l o r   t r a n s C o l o r )  
 	 {  
 	 	 N e w T r a n s p a r e n t C o l o r I m a g e ( i m a g e N a m e ,   f i l e N a m e ,   t r a n s C o l o r ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   N e w S o u n d ( s t r i n g   s o u n d N a m e ,   s t r i n g   f i l e n a m e )  
 	 {  
 	 	 _ S o u n d s . A d d ( s o u n d N a m e ,   A u d i o . L o a d S o u n d E f f e c t ( S w i n G a m e . P a t h T o R e s o u r c e ( f i l e n a m e ,   R e s o u r c e K i n d . S o u n d R e s o u r c e ) ) ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   N e w M u s i c ( s t r i n g   m u s i c N a m e ,   s t r i n g   f i l e n a m e )  
 	 {  
 	 	 _ M u s i c . A d d ( m u s i c N a m e ,   A u d i o . L o a d M u s i c ( S w i n G a m e . P a t h T o R e s o u r c e ( f i l e n a m e ,   R e s o u r c e K i n d . S o u n d R e s o u r c e ) ) ) ;  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   F r e e F o n t s ( )  
 	 {  
 	 	 F o n t   o b j   =   d e f a u l t ( F o n t ) ;  
 	 	 f o r e a c h   (   o b j   i n   _ F o n t s . V a l u e s )   {  
 	 	 	 S w i n G a m e . F r e e F o n t ( o b j ) ;  
 	 	 }  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   F r e e I m a g e s ( )  
 	 {  
 	 	 B i t m a p   o b j   =   d e f a u l t ( B i t m a p ) ;  
 	 	 f o r e a c h   (   o b j   i n   _ I m a g e s . V a l u e s )   {  
 	 	 	 S w i n G a m e . F r e e B i t m a p ( o b j ) ;  
 	 	 }  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   F r e e S o u n d s ( )  
 	 {  
 	 	 S o u n d E f f e c t   o b j   =   d e f a u l t ( S o u n d E f f e c t ) ;  
 	 	 f o r e a c h   (   o b j   i n   _ S o u n d s . V a l u e s )   {  
 	 	 	 A u d i o . F r e e S o u n d E f f e c t ( o b j ) ;  
 	 	 }  
 	 }  
  
 	 p r i v a t e   s t a t i c   v o i d   F r e e M u s i c ( )  
 	 {  
 	 	 M u s i c   o b j   =   d e f a u l t ( M u s i c ) ;  
 	 	 f o r e a c h   (   o b j   i n   _ M u s i c . V a l u e s )   {  
 	 	 	 A u d i o . F r e e M u s i c ( o b j ) ;  
 	 	 }  
 	 }  
  
 	 p u b l i c   s t a t i c   v o i d   F r e e R e s o u r c e s ( )  
 	 {  
 	 	 F r e e F o n t s ( ) ;  
 	 	 F r e e I m a g e s ( ) ;  
 	 	 F r e e M u s i c ( ) ;  
 	 	 F r e e S o u n d s ( ) ;  
 	 	 S w i n G a m e . P r o c e s s E v e n t s ( ) ;  
 	 }  
 }  
 