from django.urls import path

from . import views

urlpatterns = [
    path('', views.namasteView, name='namastePage'),
]
