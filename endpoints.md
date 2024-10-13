| Method | Route | Function Name | Description | Auth Roles | Usage |
|--------|-------|---------------|-------------|------------|-------|
| POST | /api/auth/register | RegisterUser | Register a new user | None | Public |
| POST | /api/auth/login | LoginUser | Authenticate a user and get a token | None | Public |
| POST | /api/auth/admin-login | AdminLogin | Authenticate an admin user | None | Admin |
| POST | /api/auth/refresh-token | RefreshToken | Refresh the authentication token | Customer, Admin | Both |
| GET | /api/auth/profile | GetUserProfile | Get the current user's profile | Customer, Admin | Both |
| PUT | /api/auth/profile | UpdateUserProfile | Update the current user's profile | Customer, Admin | Both |
| GET | /api/categories | GetCategories | Retrieve a list of product categories | None | Public |
| GET | /api/categories/{id}/subcategories | GetSubcategories | Retrieve subcategories of a specific category | None | Public |
| POST | /api/categories | CreateCategory | Create a new category | Admin | Admin |
| PUT | /api/categories/{id} | UpdateCategory | Update an existing category | Admin | Admin |
| DELETE | /api/categories/{id} | DeleteCategory | Delete a category | Admin | Admin |
| GET | /api/products | GetProducts | Retrieve a list of products with pagination and filtering | None | Public |
| GET | /api/products/{id} | GetProductById | Retrieve details of a specific product | None | Public |
| POST | /api/products | CreateProduct | Create a new product | Admin | Admin |
| PUT | /api/products/{id} | UpdateProduct | Update an existing product | Admin | Admin |
| DELETE | /api/products/{id} | DeleteProduct | Delete a product | Admin | Admin |
| GET | /api/products/category/{categoryId} | GetProductsByCategory | Retrieve products in a specific category | None | Public |
| GET | /api/products/search | SearchProducts | Search for products based on various criteria | None | Public |
| GET | /api/products/featured | GetFeaturedProducts | Retrieve a list of featured products | None | Public |
| GET | /api/products/{id}/related | GetRelatedProducts | Get products related to a specific product | None | Public |
| GET | /api/products/recommendations | GetProductRecommendations | Get personalized product recommendations | Customer | Public |
| GET | /api/products/low-stock | GetLowStockProducts | Retrieve products with low stock | Admin | Admin |
| POST | /api/products/{id}/discount | ApplyProductDiscount | Apply a discount to a specific product | Admin | Admin |
| GET | /api/products/{id}/inventory-history | GetProductInventoryHistory | Retrieve inventory history for a product | Admin | Admin |
| POST | /api/products/bulk-update | BulkUpdateProducts | Update multiple products at once | Admin | Admin |
| GET | /api/products/{id}/variants | GetProductVariants | Retrieve variants of a specific product | None | Public |
| POST | /api/products/{id}/variants | CreateProductVariant | Create a new variant for a product | Admin | Admin |
| PUT | /api/products/{id}/variants/{variantId} | UpdateProductVariant | Update an existing product variant | Admin | Admin |
| DELETE | /api/products/{id}/variants/{variantId} | DeleteProductVariant | Delete a product variant | Admin | Admin |
| GET | /api/products/{id}/images | GetProductImages | Retrieve images of a specific product | None | Public |
| POST | /api/products/{id}/images | AddProductImage | Add a new image to a product | Admin | Admin |
| DELETE | /api/products/{id}/images/{imageId} | DeleteProductImage | Delete an image from a product | Admin | Admin |
| GET | /api/products/{id}/inventory | GetProductInventory | Get current inventory of a product | Admin | Admin |
| PUT | /api/products/{id}/stock | UpdateProductStock | Update stock of a product | Admin | Admin |
| GET | /api/products/discontinued | GetDiscontinuedProducts | Get list of discontinued products | Admin | Admin |
| GET | /api/reviews/product/{productId} | GetProductReviews | Retrieve reviews for a specific product | None | Public |
| POST | /api/reviews | CreateReview | Create a new review | Customer | Public |
| GET | /api/reviews | GetAllReviews | Retrieve a list of all reviews | Admin | Admin |
| PUT | /api/reviews/{id} | UpdateReview | Update an existing review | Admin | Admin |
| DELETE | /api/reviews/{id} | DeleteReview | Delete a review | Admin | Admin |
| GET | /api/cart | GetCart | Retrieve the current user's shopping cart | Customer | Public |
| POST | /api/cart | AddToCart | Add a product to the shopping cart | Customer | Public |
| PUT | /api/cart | UpdateCart | Update the shopping cart | Customer | Public |
| DELETE | /api/cart/{productId} | RemoveFromCart | Remove a product from the cart | Customer | Public |
| GET | /api/customers/{customerId}/wishlist | GetWishlist | Retrieve the customer's wishlist | Customer | Public |
| POST | /api/customers/{customerId}/wishlist | AddToWishlist | Add a product to the wishlist | Customer | Public |
| DELETE | /api/customers/{customerId}/wishlist/{productId} | RemoveFromWishlist | Remove a product from the wishlist | Customer | Public |
| POST | /api/wishlist/move-to-cart | MoveWishlistToCart | Move items from wishlist to cart | Customer | Public |
| GET | /api/customers/{customerId}/addresses | GetCustomerAddresses | Retrieve addresses for a specific customer | Customer, Admin | Both |
| POST | /api/customers/{customerId}/addresses | CreateCustomerAddress | Create a new address for a customer | Customer, Admin | Both |
| PUT | /api/customers/{customerId}/addresses/{addressId} | UpdateCustomerAddress | Update an existing customer address | Customer, Admin | Both |
| DELETE | /api/customers/{customerId}/addresses/{addressId} | DeleteCustomerAddress | Delete a customer address | Customer, Admin | Both |
| POST | /api/orders | CreateOrder | Create a new order | Customer | Public |
| GET | /api/orders | GetOrders | Retrieve orders (all for admin, own for customer) | Customer, Admin | Both |
| GET | /api/orders/{id} | GetOrderById | Retrieve details of a specific order | Customer, Admin | Both |
| PUT | /api/orders/{id}/status | UpdateOrderStatus | Update the status of an order | Admin | Admin |
| POST | /api/orders/{id}/cancel | CancelOrder | Cancel an existing order | Customer, Admin | Both |
| POST | /api/orders/{id}/refund | RefundOrder | Process a refund for an order | Admin | Admin |
| GET | /api/orders/{id}/tracking | GetOrderTracking | Retrieve tracking information for an order | Customer, Admin | Both |
| POST | /api/orders/{id}/tracking | AddOrderTracking | Add tracking information to an order | Admin | Admin |
| GET | /api/orders/{id}/items | GetOrderItems | Retrieve items of a specific order | Customer, Admin | Both |
| GET | /api/orders/{id}/payment | GetOrderPayment | Get payment details for an order | Customer, Admin | Both |
| POST | /api/orders/{id}/payment | CreateOrderPayment | Create a payment for an order | Customer | Public |
| PUT | /api/orders/{id}/payment | UpdateOrderPayment | Update payment details for an order | Admin | Admin |
| GET | /api/payments | GetAllPayments | Retrieve a list of all payments | Admin | Admin |
| POST | /api/coupons/validate | ValidateCoupon | Validate a coupon code | Customer | Public |
| GET | /api/coupons | GetCoupons | Retrieve a list of coupons | Admin | Admin |
| POST | /api/coupons | CreateCoupon | Create a new coupon | Admin | Admin |
| PUT | /api/coupons/{id} | UpdateCoupon | Update an existing coupon | Admin | Admin |
| DELETE | /api/coupons/{id} | DeleteCoupon | Delete a coupon | Admin | Admin |
| GET | /api/coupons/{id}/usage | GetCouponUsage | Get usage statistics for a coupon | Admin | Admin |
| PUT | /api/coupons/{id}/activate | ActivateCoupon | Activate a coupon | Admin | Admin |
| PUT | /api/coupons/{id}/deactivate | DeactivateCoupon | Deactivate a coupon | Admin | Admin |
| GET | /api/customers | GetCustomers | Retrieve a list of customers | Admin | Admin |
| GET | /api/customers/{id} | GetCustomerById | Retrieve details of a specific customer | Admin | Admin |
| PUT | /api/customers/{id} | UpdateCustomer | Update a customer's information | Admin | Admin |
| POST | /api/customers/{id}/note | AddCustomerNote | Add a note to a customer's profile | Admin | Admin |
| GET | /api/customers/top | GetTopCustomers | Retrieve top customers based on purchase history | Admin | Admin |
| GET | /api/customers/{id}/purchase-history | GetCustomerPurchaseHistory | Retrieve purchase history for a specific customer | Admin | Admin |
| GET | /api/analytics/sales | GetSalesAnalytics | Retrieve sales analytics data | Admin | Admin |
| GET | /api/analytics/top-products | GetTopSellingProducts | Retrieve top-selling products | Admin | Admin |
| GET | /api/analytics/customer-retention | GetCustomerRetentionData | Retrieve customer retention analytics | Admin | Admin |
| GET | /api/inventory/stock-alerts | GetStockAlerts | Retrieve stock alerts for low inventory | Admin | Admin |
| GET | /api/reports/sales | GenerateSalesReport | Generate a sales report | Admin | Admin |
| GET | /api/reports/inventory | GenerateInventoryReport | Generate an inventory report | Admin | Admin |
