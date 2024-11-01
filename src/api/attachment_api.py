from flask import Blueprint, request, jsonify

attachment_api = Blueprint('attachment_api', __name__)

# In-memory storage for attachments
attachments = {}

# Endpoint to create an attachment
@attachment_api.route('/attachments', methods=['POST'])
def create_attachment():
    data = request.json
    item_id = data.get('item_id')
    attachment_data = data.get('attachment')
    if not item_id or not attachment_data:
        return jsonify({'error': 'Invalid data'}), 400
    attachments[item_id] = attachment_data
    return jsonify({'message': 'Attachment created'}), 201

# Endpoint to get an attachment
@attachment_api.route('/attachments/<item_id>', methods=['GET'])
def get_attachment(item_id):
    attachment = attachments.get(item_id)
    if not attachment:
        return jsonify({'error': 'Attachment not found'}), 404
    return jsonify({'attachment': attachment}), 200

# Endpoint to update an attachment
@attachment_api.route('/attachments/<item_id>', methods=['PUT'])
def update_attachment(item_id):
    data = request.json
    attachment_data = data.get('attachment')
    if not attachment_data:
        return jsonify({'error': 'Invalid data'}), 400
    attachments[item_id] = attachment_data
    return jsonify({'message': 'Attachment updated'}), 200
