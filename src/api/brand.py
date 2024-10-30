from flask import Blueprint, request, jsonify
from models import Brand
from auth import requires_auth

brand_api = Blueprint('brand_api', __name__)

@brand_api.route('/brands', methods=['GET'])
@requires_auth
def get_brands():
    brands = Brand.query.all()
    return jsonify([brand.to_dict() for brand in brands]), 200

@brand_api.route('/brands', methods=['POST'])
@requires_auth
def create_brand():
    data = request.json
    new_brand = Brand(**data)
    new_brand.save()
    return jsonify(new_brand.to_dict()), 201

@brand_api.route('/brands/<int:brand_id>', methods=['PUT'])
@requires_auth
def update_brand(brand_id):
    data = request.json
    brand = Brand.query.get_or_404(brand_id)
    brand.update(**data)
    return jsonify(brand.to_dict()), 200

@brand_api.route('/brands/<int:brand_id>', methods=['DELETE'])
@requires_auth
def delete_brand(brand_id):
    brand = Brand.query.get_or_404(brand_id)
    brand.delete()
    return '', 204
